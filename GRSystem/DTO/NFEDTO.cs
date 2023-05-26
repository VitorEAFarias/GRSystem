using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class NFEDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ID_PROCEDIMENTO"></param>
        /// <param name="NFE"></param>
        public NFEDTO(int ID, int ID_PROCEDIMENTO, string NFE)
        {
            this.ID = ID;
            this.ID_PROCEDIMENTO = ID_PROCEDIMENTO;
            this.NFE = NFE;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_PROCEDIMENTO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string NFE { get; set; }
    }
}
