//Erişim berlileyiciler
// * Public
// * Private
// * Internal
// * Protected
Calışan calışan1 = new Calışan();
calışan1.Ad = "Mouhamed";
calışan1.SoyAdı = "FARDOUSI ";
calışan1.No = 6542;
calışan1.Departman = "Bilişim";
calışan1.CalisanBilgileri();
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
}
