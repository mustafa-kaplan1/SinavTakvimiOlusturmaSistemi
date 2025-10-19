public class KullaniciBilgileri
{
    public string Eposta { get; set; }
    public string Rol { get; set; }
    public string AdminRol { get; set; }

    // Singleton instance
    private static KullaniciBilgileri? instance = null;
    public static KullaniciBilgileri Instance
    {
        get
        {
            if (instance == null)
                instance = new KullaniciBilgileri();
            return instance;
        }
    }

    private KullaniciBilgileri() { }
}
