﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bot_Dofus_1._29._1.Managers.Accounts;

/*
    Este archivo es parte del proyecto BotDofus_1.29.1

    BotDofus_1.29.1 Copyright (C) 2019 Alvaro Prendes — Todos los derechos reservados.
    Creado por Alvaro Prendes
    web: http://www.salesprendes.com
*/

namespace Bot_Dofus_1._29._1.Scripts.Acciones.Npcs
{
    public class NpcAccion : AccionesScript
    {
        public int npc_id { get; private set; }

        public NpcAccion(int _npc_id)
        {
            npc_id = _npc_id;
        }

        internal override Task<ResultadosAcciones> proceso(Account cuenta)
        {
            if (cuenta.Is_Busy())
                return resultado_fallado;

            Game.Mapas.Entidades.Npcs npc = null;
            IEnumerable<Game.Mapas.Entidades.Npcs> npcs = cuenta.Game.Map.lista_npcs();

            if (npc_id < 0)
            {
                int index = (npc_id * -1) - 1;

                if (npcs.Count() <= index)
                    return resultado_fallado;

                npc = npcs.ElementAt(index);
            }
            else
                npc = npcs.FirstOrDefault(n => n.npc_modelo_id == npc_id);

            if (npc == null)
                return resultado_fallado;

            cuenta.connexion.SendPacket("DC" + npc.Id, true);
            return resultado_procesado;
        }
    }
}