using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchApp
{
    /// <summary>
    /// main class
    /// </summary>
    class ProgramInti
    {
        /// <summary>
        /// operasi luas bangun datar
        /// </summary>
        /// <param name="args"></param>
        /// <remarks>dapat memilih salah satu menu</remarks>
        static void Main(string[] args)
        {
            //membuat instance untuk kelas persegi panjang, kelas ligkaran dan kelas segitiga
            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();
            Segitiga s3 = new Segitiga();

            //deklarasi variabel untuk ekspresi Switch
            int pilih;

            //membuat tampilan Menu
            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Lingkaran");
            Console.WriteLine("3. Luas Segitiga");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan (1/2/3/4) : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (pilih) //untuk memilih case
            {
                case 1: //luas persegi
                    pp.sisiPP(); //menampilkan method sisiPP
                    pp.tampilPP(); //menampilkann method tampilPP
                    break;
                case 2: //luas lingkaran
                    lk.jariLingkaran(); //menampilkan method jariLingkaran
                    lk.tampilLing(); //menampilkan method tampilLing
                    break;
                case 3: //luas segitiga
                    s3.sisiS3(); //menampilkan method sisiS3
                    s3.tampilS3(); //menampilkan method tampilS3
                    break;
                case 4: //keluar
                    break;
                default:
                    Console.WriteLine("Pilihan salah !"); //suatu kondisi jika salah menginput nomer
                    Console.ReadKey();
                    break;
            }
        }
    }


    /// <summary>
    /// operasi luas persegi panjang
    /// </summary>
    /// <param name="p">angka pertama dalam operasi luas persegi panjang</param>
    /// <param name="l">angka kedua dalam operasi luas persegi panjang</param>
    /// <returns>hasil dari operasi luas persegi panjang</returns>
    public class PersegiPanjang
    {
        //deklarasi variabel
        public double panjang, lebar;

        //membuat method untuk input variabel yang diketahui
        public void sisiPP()
        {
            Console.Write("Masukkan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        //membuat method berupa fungsi untuk menghitung luas
        public double LuasPP(double p, double l)
        {
            return p * l;
        }
        //membuat method berupa prosedur untuk menampilkan data luas
        public void tampilPP()
        {
            Console.WriteLine("Luas Persegi panjang = " + this.LuasPP(panjang, lebar));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// operasi luas lingkaran
    /// </summary>
    /// <param name="jejari">angka pertama dalam operasi luas persegi panjang</param>
    /// <returns>hasil dari operasi luas lingkaran</returns>
    public class Lingkaran
    {
        public double jejari;
        public void jariLingkaran()
        {
            Console.Write("Masukkan jari-jari = ");
            jejari = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasLing(double r)
        {
            return 3.14 * r * r;
        }
        public void tampilLing()
        {
            Console.WriteLine("Luas Lingkaran = " + this.LuasLing(jejari));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// operasi luas segitiga
    /// </summary>
    /// <param name="alas">angka pertama dalam operasi luas segitiga</param>
    /// <param name="tinggi">angka kedua dalam operasi luas segitiga</param>
    /// <returns>hasil dari operasi luas segitiga</returns>
    public class Segitiga
    {
        public double alas, tinggi;
        public void sisiS3()
        {
            Console.Write("Masukkan alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasS3(double a, double t)
        {
            return 0.5 * a * t;
        }
        public void tampilS3()
        {
            Console.WriteLine("Luas Segitiga = " + this.LuasS3(alas, tinggi));
            Console.ReadKey();
        }
    }
}