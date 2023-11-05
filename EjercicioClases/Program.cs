// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


SuperHeroe superHeroe = new SuperHeroe();

superHeroe.Nombre = "superman";
superHeroe.IdentidadSecreta = "Clark Kent";
superHeroe.Ciudad = "Metropolis";
superHeroe.PuedeVolar = true;
superHeroe.superPoder.Nombre = "Super Fuerza";
superHeroe.descripcion.Descripcion = "Cpacidad de levantar objetos muy pesados";
superHeroe.nivel.Nivel = 9;


public class SuperHeroe { 
    public string Nombre {  get; set; } 
    public string IdentidadSecreta { get; set; }    
    public string Ciudad {  get; set; } 
    public bool PuedeVolar {  get; set; }   
    public SuperPoder superPoder { get; set; }
    public SuperPoder descripcion { get; set; }
    public SuperPoder nivel { get; set; }

}

public class SuperPoder {
    public string Nombre { get; set; } 
    public string Descripcion { get; set; } 
    public int Nivel {  get; set; }
}