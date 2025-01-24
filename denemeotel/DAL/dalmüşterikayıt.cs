using denemeotel.ENTİTYLAYER;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeotel.DAL
{
    internal class dalmüşterikayıt
    {
        public bool MüşteriKaydet(elmüşterikayıt müşteri)
        {
            try
            {
                using (var conn = new baglantı().getir())
                {
                    int müşteriId;

                    MySqlCommand müşteriKontrol = new MySqlCommand(@"
                        SELECT CustomerID FROM Customers 
                        WHERE IdentityNumber = @identityNumber", conn);
                    
                    müşteriKontrol.Parameters.AddWithValue("@identityNumber", müşteri.TCKİMLİKNO);
                    var existingCustomerId = müşteriKontrol.ExecuteScalar();
                    
                    if (existingCustomerId != null)
                    {
                        müşteriId = Convert.ToInt32(existingCustomerId);
                    }
                    else
                    {
                        MySqlCommand cmdMüşteri = new MySqlCommand(@"
                            INSERT INTO Customers (FirstName, LastName, PhoneNumber, IdentityNumber) 
                            VALUES (@firstName, @lastName, @phoneNumber, @identityNumber);
                            SELECT LAST_INSERT_ID();", conn);

                        cmdMüşteri.Parameters.AddWithValue("@firstName", müşteri.ADI);
                        cmdMüşteri.Parameters.AddWithValue("@lastName", müşteri.SOYADI);
                        cmdMüşteri.Parameters.AddWithValue("@phoneNumber", müşteri.TELEFONNO);
                        cmdMüşteri.Parameters.AddWithValue("@identityNumber", müşteri.TCKİMLİKNO);

                        müşteriId = Convert.ToInt32(cmdMüşteri.ExecuteScalar());
                    }

                    MySqlCommand odaKontrol = new MySqlCommand(@"
                        SELECT COUNT(*) FROM Rooms 
                        WHERE RoomNumber = @roomNumber", conn);
                    
                    if (string.IsNullOrEmpty(müşteri.ODANO))
                    {
                        throw new Exception("Lütfen bir oda numarası seçiniz!");
                    }

                    string temizOdaNo = müşteri.ODANO.Trim();
                    int odaNo;
                    if (!int.TryParse(temizOdaNo, out odaNo))
                    {
                        throw new Exception($"Oda numarası sayısal bir değer olmalıdır! Girilen değer: '{temizOdaNo}'");
                    }
                    
                    odaKontrol.Parameters.AddWithValue("@roomNumber", odaNo);
                    int odaSayisi = Convert.ToInt32(odaKontrol.ExecuteScalar());
                    
                    if (odaSayisi == 0)
                    {
                        MySqlCommand mevcutOdalar = new MySqlCommand("SELECT GROUP_CONCAT(RoomNumber) FROM Rooms", conn);
                        string odaListesi = mevcutOdalar.ExecuteScalar()?.ToString() ?? "";
                        
                        throw new Exception($"Oda numarası ({odaNo}) sistemde bulunamadı! Mevcut odalar: {odaListesi}");
                    }

                    MySqlCommand tarihKontrol = new MySqlCommand(@"
                        SELECT COUNT(*) FROM Reservations 
                        WHERE RoomNumber = @roomNumber 
                        AND NOT (CheckOutDate < @checkIn OR CheckInDate > @checkOut)", conn);
                    
                    tarihKontrol.Parameters.AddWithValue("@roomNumber", odaNo);
                    tarihKontrol.Parameters.AddWithValue("@checkIn", müşteri.GİRİŞTARİHİ);
                    tarihKontrol.Parameters.AddWithValue("@checkOut", müşteri.ÇIKIŞTARİHİ);
                    
                    int tarihCakismasi = Convert.ToInt32(tarihKontrol.ExecuteScalar());
                    if (tarihCakismasi > 0)
                    {
                        throw new Exception($"Seçilen tarih aralığında oda ({odaNo}) başka bir rezervasyon için kullanımda!");
                    }


                    MySqlCommand cmdRezervasyon = new MySqlCommand(@"
                        INSERT INTO Reservations (CustomerID, RoomNumber, CheckInDate, CheckOutDate, TotalAmount)
                        VALUES (@customerId, @roomNumber, @checkInDate, @checkOutDate, @totalAmount)", conn);

                    cmdRezervasyon.Parameters.AddWithValue("@customerId", müşteriId);
                    cmdRezervasyon.Parameters.AddWithValue("@roomNumber", odaNo);
                    cmdRezervasyon.Parameters.AddWithValue("@checkInDate", müşteri.GİRİŞTARİHİ);
                    cmdRezervasyon.Parameters.AddWithValue("@checkOutDate", müşteri.ÇIKIŞTARİHİ);
                    cmdRezervasyon.Parameters.AddWithValue("@totalAmount", müşteri.ÜCRET);

                    cmdRezervasyon.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool OdaDurumunuGüncelle(string odaNo, string durum)
        {
            try
            {
                using (var conn = (new baglantı()).getir())
                {
                    MySqlCommand cmd = new MySqlCommand(@"
                        UPDATE Rooms SET Status = @status
                        WHERE RoomNumber = @roomNumber", conn);

                    cmd.Parameters.AddWithValue("@status", durum);
                    cmd.Parameters.AddWithValue("@roomNumber", odaNo);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
