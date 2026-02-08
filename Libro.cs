using System;
namespace INF512
{
public class Libro
{
    public string {get:set;}
  public string Autor{get;set}
  public int AnioPublicacion {get;set;}
  public Libro (string titulo,string autor, int anio)
  {
    Titulo= titulo;
    Autor= autor;
    Aniopublicacion=anio
    }
  public void MostrarDetalles()
  {
    Console. WriteLine($"Titulo: {Titulo}");
                       Console.WriteLine($"Autor:{Autor}");
    Console.WriteLine($Anio de Publicacion:{AnioPublicacion}");
                      }
                      }
                      }
                                         
                       
