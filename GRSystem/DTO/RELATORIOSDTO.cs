using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class RELATORIOSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ID_TAG_OFFICE"></param>
        /// <param name="ID_TAG_SERVICE"></param>
        /// <param name="RELATORIOS"></param>
        public RELATORIOSDTO(int ID, int ID_TAG_OFFICE, int ID_TAG_SERVICE, byte[] RELATORIOS)
        {
            this.ID = ID;
            this.ID_TAG_OFFICE = ID_TAG_OFFICE;
            this.ID_TAG_SERVICE = ID_TAG_SERVICE;
            this.RELATORIOS = RELATORIOS;
        }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_TAG_OFFICE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int ID_TAG_SERVICE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual byte[] RELATORIOS { get; set; }
    }
}
