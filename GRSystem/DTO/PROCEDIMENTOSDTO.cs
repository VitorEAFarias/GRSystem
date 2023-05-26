using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class PROCEDIMENTOSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ID_CADASTRO"></param>
        /// <param name="PROCEDIMENTO"></param>
        /// <param name="ID_CONSERTO"></param>
        /// <param name="ID_GARANTIA"></param>
        public PROCEDIMENTOSDTO(int ID, int ID_CADASTRO, string PROCEDIMENTO, int ID_CONSERTO, int ID_GARANTIA)
        {
            this.ID = ID;
            this.ID_CADASTRO = ID_CADASTRO;
            this.PROCEDIMENTO = PROCEDIMENTO;
            this.ID_CONSERTO = ID_CONSERTO;
            this.ID_GARANTIA = ID_GARANTIA;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_CADASTRO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string PROCEDIMENTO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_CONSERTO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_GARANTIA { get; set; }
    }
}
