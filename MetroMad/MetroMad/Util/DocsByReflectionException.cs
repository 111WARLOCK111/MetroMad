//This class is copyright of Jim Blackler, 2008.
//jimblackler@gmail.com
//
//This is free class. This class is distributed under the terms of the GNU Lesser
//General Public License. Please see the files LICENSE or LICENSE.txt

using System;

namespace JimBlackler.DocsByReflection
{
    /// <summary>
    /// An exception thrown by the DocsByReflection library
    /// </summary>
    [Serializable]
    class DocsByReflectionException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance with the specified
        /// error message and a reference to the inner exception that is the cause of
        /// this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or null if none.</param>
        public DocsByReflectionException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}