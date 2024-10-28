using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class PuntosPersons
    {
    public int Id { get; set; }
    public int PersonId { get; set; } //identificador
    public int LibroId { get; set; }  //identificador libroobtenido
    public int Puntos { get; set; } = 1; //puntos por cada libro obtenido
    [NotMapped]
    public int AcumuladorPuntos { get; set; } //campo que acumula los puntos del jugador
    }

