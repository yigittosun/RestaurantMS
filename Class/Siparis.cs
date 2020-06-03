﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yigit_Cafe
{
    class Siparis
    {
        public static bool siparisEkle(object masaNo)
        {
           Veritabani.baglantiKontrol();

            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into Siparis (MasaNo,Hesap) values (@masano,True)", Veritabani.con);
                cmd.Parameters.Add("@masano", OleDbType.Integer).Value = masaNo;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }


        }
        public static bool siparisUrunEkle(object siparisNo, object urunNo, object urunAdet)
        {
            Veritabani.baglantiKontrol();
            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into SiparisUrun (SiparisNo,UrunNo,UrunAdet) values (@siparisNo,@urunNo,@urunAdet)", Veritabani.con);
                cmd.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo;
                cmd.Parameters.Add("@urunNo", OleDbType.Integer).Value = urunNo;
                cmd.Parameters.Add("@urunAdet", OleDbType.Integer).Value = urunAdet;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool siparisUrunTemizle(object siparisNo)
        {
            Veritabani.baglantiKontrol();
            try
            {

                OleDbCommand sil = new OleDbCommand("delete from SiparisUrun where SiparisNo=@siparisNo", Veritabani.con);
                sil.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo;
                sil.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
        }
        
        
        public static bool siparisTemizle(object siparisNo)
        {
            Veritabani.baglantiKontrol();
            try
            {

                OleDbCommand sil = new OleDbCommand("delete from Siparis where SiparisNo=@siparisNo", Veritabani.con);
                sil.Parameters.Add("@siparisNo", OleDbType.Integer).Value = siparisNo;
                sil.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
        }
        public static int siparisNoGetir(object masaNo)
        {
            DataTable dt = Veritabani.VeriGetir("select SiparisNo from Siparis where MasaNo=" + masaNo + " AND Hesap=True");
            if (dt.Rows.Count > 0)
            {
                int siparisNo = Convert.ToInt32(dt.Rows[0][0].ToString());
                return siparisNo;
            }
            else
            {
                return -1;
            }
        }
        }
    }
