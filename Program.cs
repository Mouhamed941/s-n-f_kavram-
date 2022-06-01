//Erişim berlileyiciler
// * Public
// * Private
// * Internal
// * Protected
Calışan calışan1 = new Calışan{Ad = "Mouhamed", SoyAdı = "FARDOUSI ", No = 6542, Departman = "Bilişim"};
Calışan calışan2 = new Calışan{Ad = "Ali", SoyAdı = "FARDOUSI ", No = 6541, Departman = "Montaj"};
Calışan calışan3 = new Calışan{Ad="Mouhamed",SoyAdı="yılmaz"};

calışan1.CalisanBilgileri();
calışan2.CalisanBilgileri();
calışan3.CalisanBilgileri();
class Calışan
{
    public string Ad ;
    public string SoyAdı ;
    public int No ;

    public string Departman;
    public void CalisanBilgileri()
    {
        System.Console.WriteLine($"Çalışan adi : {Ad}");
        System.Console.WriteLine($"Çalışan Soyadi : {SoyAdı}");
        System.Console.WriteLine($"Çalışan No :  {No}");
        System.Console.WriteLine($"Çalışan Departmant : {Departman}");
    }
    public Calışan(string ad ,string soyad ,int no ,string departman)
    {
        this.Ad = ad;       //this => Bu sınıfın elemanı
        this.SoyAdı = soyad;
        this.No = no ;
        this.Departman = departman;
    }
    public Calışan(){}
    public Calışan(string ad,string soyad){
        this.Ad = ad;
        this.SoyAdı = soyad;
    }
}
