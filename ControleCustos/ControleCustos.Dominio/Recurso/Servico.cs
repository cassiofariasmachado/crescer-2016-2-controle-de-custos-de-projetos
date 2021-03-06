﻿using ControleCustos.Dominio.Enum;

namespace ControleCustos.Dominio
{
    public class Servico : Recurso
    {
        public string Descricao { get; private set; }

        public TipoServico TipoServico { get; private set; }

        public Servico() { }

        public Servico(int id,
            string nome,
            decimal valorMensal,
            SituacaoRecurso situacao,
            bool interno,
            string descricao,
            TipoServico tipoServico)
            : base(id, nome, valorMensal, situacao, interno)
        {
            this.Descricao = descricao;
            this.TipoServico = tipoServico;
        }
    }
}
