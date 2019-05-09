using System;

namespace Api.Reduca.Models
{
    /// <summary>
    /// Entidade usuário
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Id do usuário
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Tipo de usuário
        /// </summary>
        public string TipoUsuario { get; set; }

        /// <summary>
        /// Data de nascimento do usuário
        /// </summary>
        public string Nascimento { get; set; }

        /// <summary>
        /// RG do usuário
        /// </summary>
        public string RG { get; set; }

        /// <summary>
        /// CPF do usuário
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Endereco do usuário
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Bairro do usuário
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Telefone do usuário
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// Celular do usuário
        /// </summary>
        public string Celular { get; set; }

        /// <summary>
        /// Email do usuário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Ocupação do usuário
        /// </summary>
        public string Ocupacao { get; set; }

        /// <summary>
        /// Formação do usuário
        /// </summary>
        public string Formacao { get; set; }

        /// <summary>
        /// Disponibilidade do usuário
        /// </summary>
        public DateTime HorarioDisponivel { get; set; }

        /// <summary>
        /// Carga horária semanal do usuário
        /// </summary>
        public int CargaHoraria { get; set; }

        /// <summary>
        /// Setor preferência do usuário
        /// </summary>
        public string Setor { get; set; }

        /// <summary>
        /// TEmpo de atuação do usuário
        /// </summary>
        public string TempoAtuacao { get; set; }

        /// <summary>
        /// Ajuda de custo do usuário
        /// </summary>
        public string AjudaCusto { get; set; }

        /// <summary>
        /// Frequência de realização de atividade do usuário
        /// </summary>
        public string FrequenciaAtividade { get; set; }

        /// <summary>
        /// Necessita de materiais do usuário
        /// </summary>
        public bool Materiais { get; set; }

        /// <summary>
        /// Faixa etária do usuário
        /// </summary>
        public int FaixaEtaria { get; set; }

        /// <summary>
        /// Descrição do usuário
        /// </summary>
        public string Descricao { get; set; }
    }
}
