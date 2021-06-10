namespace CodeWars.CodeWars._8kyu
{
    internal class Welcome
    {
        public static string Greet(string language)
        {
            return language switch
            {
                "czech" => "Vitejte",
                "danish" => "Velkomst",
                "dutch" => "Welkom",
                "estonian" => "Tere tulemast",
                "finnish" => "Tervetuloa",
                "flemish" => "Welgekomen",
                "french" => "Bienvenue",
                "german" => "Willkommen",
                "irish" => "Failte",
                "italian" => "Benvenuto",
                "latvian" => "Gaidits",
                "lithuanian" => "Laukiamas",
                "polish" => "Witamy",
                "spanish" => "Bienvenido",
                "swedish" => "Valkommen",
                "welsh" => "Croeso",
                _ => "Welcome"
            };
        }
    }
}