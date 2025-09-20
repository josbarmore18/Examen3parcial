﻿using System.Collections.Generic;

namespace GarajeMVC.Models
{
    public class Garaje
    {
        public int numeroGaraje { get; set; }
        public string descripcion { get; set; }
        public int capacidadEspacios { get; set; }
        public int espaciosOcupados { get; set; }
        public List<Auto> autos { get; set; }

        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = espaciosOcupados;
            this.autos = new List<Auto>();
        }

        public void ingresarAuto(Auto auto)
        {
            this.autos.Add(auto);
            this.espaciosOcupados++;
        }

        public List<Auto> getAutos()
        {
            return this.autos;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }
    }
}