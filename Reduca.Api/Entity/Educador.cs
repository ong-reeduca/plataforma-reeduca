using System;

namespace Reduca.Api.Entity
{
    /// <summary>
    /// Entidade do documento Educador
    /// </summary>
    public class Educador
    {
        /// <summary>
        /// Id do educador.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do educador.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de nascimento do educador
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// RG do educador
        /// </summary>
        public string RG { get; set; }

        /// <summary>
        /// CPF do educador
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Endereço do educador
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Numero do endereço do educador
        /// </summary>
        public int EnderecoNumero { get; set; }

        /// <summary>
        /// Cidade do educador
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Telefone do educador
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// Email do educador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Ocupacao do educador
        /// </summary>
        public string Ocupacao { get; set; }

        /// <summary>
        /// Formacao do educador
        /// </summary>
        public string Formacao { get; set; }

        /// <summary>
        /// Comentario sobre o cargo (ensino)
        /// </summary>
        public string Comentario { get; set; }
    }
}
