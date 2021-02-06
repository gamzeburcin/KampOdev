using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev
{
    class MyDictionary<Tno, Tname>
    {
        Tno[] No;  //No array tanımlanıyor.
        Tname[] Names;   //Names array tanımlıyor.
                         //--------------------Constructor---------------//
        public MyDictionary()
        {
            No = new Tno[0]; //Dictionary çalıştığında 0 elemanlı No array oluşturuluyor
            Names = new Tname[0];  //Dictionary çalıştığında 0 elemanlı Name array oluşuyor.

        }
        //Constructor
        //Add (ekleme)

        public void Add(Tno no, Tname name)
        {
            Tno[] tempNo = No;  //Geçici No array oluşturulup No eşitleniyor.
            Tname[] tempName = Names;  //Geçici Name array oluşturulup Name eşitleniyor.
            No = new Tno[tempNo.Length + 1];   //No array'a 1 eleman eklenmis yeni array tanimlaniyor.
            Names = new Tname[tempName.Length + 1];   //Name array'a 1 eleman eklenmis yeni array tanimlaniyor.
            for (int i = 0; i < tempNo.Length; i++)  //Geçici arrayde tutulan değerler ana arraye aktarılıyor.
            {
                No[i] = tempNo[i];
            }
            No[No.Length - 1] = no; //son boş elemana girdiğimiz no değeri atanıyor.


            for (int i = 0; i < tempName.Length; i++)  //Geçici arrayde tutulan değerler ana arraye aktarılıyor.
            {
                Names[i] = tempName[i];
            }
            Names[Names.Length - 1] = name; //Son bos elemana girdigimiz NAME degeri ataniyor.

        }
        //Add(ekleme)
        //Listeleme
        public void List()
        {
            for (int i = 0; i < No.Length; i++)
            {
                Console.WriteLine("Student Number: " + No[i] + " Student Name: " + Names[i]);
            }

        }
        //Listeleme
    }


}