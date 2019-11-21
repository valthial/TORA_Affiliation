using System;

namespace TORA_Affiliation.Interfaces
{
    interface ILogger
    {
        /// <summary>
        /// 
        /// </summary>
        void EmptyLine();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Info(string message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Warn(string message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        void Error(string error);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        /// <param name="ex"></param>
        void Error(string error, Exception ex);
    }
}
