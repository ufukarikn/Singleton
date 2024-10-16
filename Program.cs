// Singleton örneğini al
using singleton;

Singleton instance1 = Singleton.Instance;
        instance1.SomeMethod();

        // Yeni bir referans al
        Singleton instance2 = Singleton.Instance;
        instance2.SomeMethod();

        // Her iki referansın aynı örneğe işaret ettiğini kontrol et
        Console.WriteLine(instance1 == instance2);  // True