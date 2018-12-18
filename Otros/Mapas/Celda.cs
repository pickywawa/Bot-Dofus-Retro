﻿/*
    Este archivo es parte del proyecto BotDofus_1.29.1

    BotDofus_1.29.1 Copyright (C) 2018 Alvaro Prendes — Todos los derechos reservados.
    Creado por Alvaro Prendes
    web: http://www.salesprendes.com
*/
namespace Bot_Dofus_1._29._1.Otros.Mapas
{
    public class Celda
    {
        public int id_celda { get; set; } = 0;
        public int objeto_interactivo_id { get; set; } = 0;
        public byte tipo_caminable { get; set; } = 0;
        public bool es_linea_vision { get; set; } = false;
        public bool object2Movement { get; set; } = false;

        public Celda(int _id_celda)
        {
            id_celda = _id_celda;
        }
    }
}
