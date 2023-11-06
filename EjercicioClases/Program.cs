

SuperHeroe superHeroe = new SuperHeroe();

superHeroe.Nombre = "superman";
superHeroe.IdentidadSecreta = "Clark Kent";
superHeroe.Ciudad = "Metropolis";
superHeroe.PuedeVolar = true;
superHeroe.superPoder.Nombre = "SuperFuerza";
superHeroe.superPoder.Descripcion = "Cpacidad de levantar objetos muy pesados";


Console.WriteLine($"Nombre: {superHeroe.Nombre}");
Console.WriteLine($"Identida Secreta: {superHeroe.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {superHeroe.Ciudad}");
Console.WriteLine($"PuedeVolar: {superHeroe.PuedeVolar}");
Console.WriteLine($"Super Poder: {superHeroe.superPoder.Nombre}");


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