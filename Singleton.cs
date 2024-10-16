using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace singleton
{
public class Singleton
{
    // 2- Statik değişken: Sınıf içinde, tekil örneği tutacak bir statik değişken tanımlanır.
    private static Singleton _instance;

    // 4-Thread Safety 
    //Çoklu iş parçacığı ortamlarında erişim güvenliğini sağlamak için lock veya diğer senkronizasyon mekanizmaları kullanılabilir.
    private static readonly object _lock = new object();

    // 1- Yapıcı metod: Singleton sınıfının yapıcısı (constructor) private olarak tanımlanır. 
    //Bu, dışarıdan yeni bir örnek oluşturulmasını engeller.
    private Singleton() 
    {
        // Başlatma işlemleri
    }

    // 3- Erişim Metodu: Tekil örneği almak için kullanılan özellik
    //Singleton örneğine erişim sağlamak için bir statik metod veya özellik (property) oluşturulur. 
    //Bu metod, örnek oluşturulmamışsa onu yaratır, yoksa mevcut örneği döner.
    public static Singleton Instance
    {
        get
        {
            // Örneğin henüz oluşturulmamışsa
            if (_instance == null)
            {
                // Eşzamanlı erişimi güvenli hale getirmek için kilitle
                lock (_lock)
                {
                    // Örnek hala null ise oluştur
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

    // Örnek bir metod
    // Soru: bu methodları cogaltarak kullanabilir miyiz? 
    // İki farklı veritabanı baglantısı var iki farklı method ekleyerek kullanabilir miyiz?
    //oracle ve mssql baglantıları gibi
    public void SomeMethod()
    {
        Console.WriteLine("Singleton örneği kullanılıyor.");
    }
}

}