using System.ComponentModel.DataAnnotations;

namespace RO_Garantias.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class NOTASITENSTAGSDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CHAVE"></param>
        /// <param name="CHAVE_NOTA"></param>
        /// <param name="CHAVE_TAG"></param>
        /// <param name="LOG_NOME"></param>
        /// <param name="LOG_DATA"></param>
        public NOTASITENSTAGSDTO(int CHAVE, int CHAVE_NOTA, int CHAVE_TAG, string LOG_NOME, string LOG_DATA)
        {
            this.CHAVE = CHAVE;
            this.CHAVE_NOTA = CHAVE_NOTA;
            this.CHAVE_TAG = CHAVE_TAG;
            this.LOG_NOME = LOG_NOME;
            this.LOG_DATA = LOG_DATA;
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public virtual int CHAVE { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_NOTA { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int CHAVE_TAG { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string LOG_NOME { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string LOG_DATA { get; private set; }
    }
}
