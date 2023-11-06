

SuperHeroe superHeroe = new SuperHeroe();
SuperHeroe superHeroeDos = new SuperHeroe();
SuperHeroe superHeroeTres = new SuperHeroe();


superHeroe.Nombre = "superman";
superHeroe.IdentidadSecreta = "Clark Kent";
superHeroe.Ciudad = "Metropolis";
superHeroe.PuedeVolar = true;
superHeroe.superPoder.Nombre = "SuperFuerza";
superHeroe.superPoder.Descripcion = "Cpacidad de levantar objetos muy pesados";
superHeroe.superPoder.Nivel = 9;

superHeroeDos.IdentidadSecreta = "Spider Man";
superHeroeDos.Ciudad = "Nueva York";
superHeroeDos.PuedeVolar = false;
superHeroeDos.superPoder.Nombre = "Telarañas artificiales";
superHeroeDos.superPoder.Descripcion = "Utiliza lanzadores de telarañas mecánicos que él mismo diseña para balancearse entre edificios, inmovilizar a los oponentes y crear redes para atrapar a los villanos.";
superHeroeDos.superPoder.Nivel = 10;


superHeroeTres.IdentidadSecreta = "Capitán América";
superHeroeTres.Ciudad = "Metropolis";
superHeroeTres.PuedeVolar = true;
superHeroeTres.superPoder.Nombre = "combate ";
superHeroeTres.superPoder.Descripcion = "Su poder radica en su ética, su liderazgo, sus habilidades de combate y su habilidad para inspirar a otros a hacer lo correcto.";
superHeroeTres.superPoder.Nivel = 7;


Console.WriteLine($"Nombre: {superHeroe.Nombre}");
Console.WriteLine($"Identida Secreta: {superHeroe.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {superHeroe.Ciudad}");
Console.WriteLine($"PuedeVolar: {superHeroe.PuedeVolar}");
Console.WriteLine($"Super Poder: {superHeroe.superPoder.Nombre}");
Console.WriteLine($"Super Poder: {superHeroe.superPoder.Descripcion}");
Console.WriteLine($"Super Poder: {superHeroe.superPoder.Nivel}");

Console.WriteLine();

Console.WriteLine($"Nombre: {superHeroeDos.Nombre}");
Console.WriteLine($"Identida Secreta: {superHeroeDos.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {superHeroeDos.Ciudad}");
Console.WriteLine($"PuedeVolar: {superHeroeDos.PuedeVolar}");
Console.WriteLine($"Super Poder: {superHeroeDos.superPoder.Nombre}");
Console.WriteLine($"Super Poder: {superHeroeDos.superPoder.Descripcion}");
Console.WriteLine($"Super Poder: {superHeroeDos.superPoder.Nivel}");


public class SuperHeroe { 
    public string? Nombre {  get; set; } 
    public string? IdentidadSecreta { get; set; }    
    public string? Ciudad {  get; set; } 
    public bool PuedeVolar {  get; set; }   
    public SuperPoder superPoder { get; set; }

    public SuperHeroe() {
        superPoder = new SuperPoder();
    }

}

public class SuperPoder {
    public string? Nombre { get; set; } 
    public string? Descripcion { get; set; } 
    public int Nivel {  get; set; }
}