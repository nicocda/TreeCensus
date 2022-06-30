using System;
using System.Collections.Generic;
using System.Text;

namespace TreeCensus
{
    public class Censo
    {
        public string Calle { get; set; }
        public string Orientacion { get; set; }
        public string Esquina1 { get; set; }
        public string Esquina2 { get; set; }
        public double AlturaCalle { get; set; }
        public bool EsPar { get; set; }
        public int Numero { get; set; }
        public bool TieneVereda { get; set; }
        public double MtsVereda { get; set; }
        public bool HayZanja { get; set; }
        public bool HayCordonCuneta { get; set; }
        public bool HayLineaMediaTension { get; set; }
        public bool HayPreensamblado { get; set; }
        public bool HayInterConAlumbado { get; set; }
        public string Especie { get; set; }
        public string RUD { get; set; }
        public string DLME { get; set; }
        public string MaA { get; set; }
        public string AaA { get; set; }
        public bool LugarDisponible { get; set; }
        public bool Cazuela { get; set; }
        public bool Jardin { get; set; }
        public double CircunfTronco { get; set; }
        public AlturaEnum Altura { get; set; }
        public PorcentajeEnum RamasDañadas { get; set; }
        public PorcentajeEnum TroncoDañado { get; set; }
        public string ElementosExtraños { get; set; }
        public int InclinacionPeligrosa { get; set; }
        public DañoPorRaicesEnum DañoPorRaices { get; set; }
        public ProblemasFitosanitariosEnum ProblemasFitosanitarios { get; set; }
        public string Otros { get; set; }
        public EstadoGeneralEnum EstadoGeneral { get; set; }
        public bool NecesitaTrabajoEnCopa { get; set; }
        public bool NecesitaTrabajoEnBase { get; set; }
    }
}

public enum AlturaEnum
{
    A6 = 6,
    A12 = 12,
    A18 = 18,
    Mas18
}

public enum PorcentajeEnum
{
    P0 = 0,
    P50 = 50,
    p80 = 80
}
public enum DañoPorRaicesEnum
{
    Alto,
    Medio,
    Bajo,
    Nada
}
public enum ProblemasFitosanitariosEnum
{
    Hongos,
    Epifitas,
    Insectos,
    Nada
}

public enum EstadoGeneralEnum
{
    Bueno,
    Regular,
    Malo,
    Muerto
}