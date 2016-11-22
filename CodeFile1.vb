Imports System.IO
Namespace Utilities
    Class TextFileManger
        Private mFile As System.IO.File
        Private mFileWriter As System.IO.StreamWriter
        Private mFileReader As System.IO.StreamReader

        'Creates a log file, default is in the documents, but another location can be given
        Public Sub openFileWrite(Optional ByVal logFilePath As String = "C:\Users\Tim\Documents\satVocabRNPAX.txt")
            mFileWriter = File.AppendText(logFilePath)
        End Sub
    End Class
End Namespace