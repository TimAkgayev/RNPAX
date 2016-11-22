Imports System
Imports System.Net
Imports System.IO
Imports System.Threading

Public Class Form1

    'log related variables
    Private saveFile As System.IO.File
    Private fileWriter As System.IO.StreamWriter
    Private fileReader As System.IO.StreamReader
    Private logFilePath As String
    Private definitionList As List(Of String) = New List(Of String)
    Private wordList As List(Of String) = New List(Of String)
    Private exampleList As List(Of String) = New List(Of String)
    Private crossWordMatrix As List(Of TextBox) = New List(Of TextBox)
    Private randIndex As Long

    'related to online interaction
    Private etymologyURL As String
    Private sampleSentenceURL As String
    Private urlResult As WebRequest
    Private objStream As Stream
    Private onlineQueryThread As Thread


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openFileRead()
        parseVocabFile(fileReader)

        onlineQueryThread = New Thread(AddressOf onlineLookupThreadProc)
        onlineQueryThread.IsBackground = True
        onlineQueryThread.Start()

    End Sub


    'Creates a log file, default is in the documents, but another location can be given
    Private Sub openFileWrite(Optional ByVal logFilePath As String = "C:\Users\Tim\Documents\satVocabRNPAX.txt")
        fileWriter = saveFile.AppendText(logFilePath)
    End Sub
    Private Sub openFileRead(Optional ByVal logFilePath As String = "C:\Users\Tim\Documents\satVocabRNPAX.txt")
        fileReader = saveFile.OpenText(logFilePath)
    End Sub



    Private Sub parseVocabFile(ByVal inFileReader As System.IO.StreamReader)
        Dim line As String
        Dim vocab As String
        Dim defin As String
        Dim example As String = " "
        Dim counter As Integer = 0

        'clear previous buffers
        WordBox.Items.Clear()
        wordList.Clear()
        definitionList.Clear()

        Do

            line = inFileReader.ReadLine()

            If (line = Nothing) Then
                Exit Do
            End If

            Dim exampleStart As Integer = line.IndexOf("<")
            vocab = line.Substring(0, line.IndexOf(","))

            If (exampleStart = -1) Then
                defin = line.Substring(line.IndexOf(",") + 1)
            Else
                defin = line.Substring(line.IndexOf(",") + 1, exampleStart)
                example = line.Substring(line.IndexOf("<") + 1)
            End If

            wordList.Add(vocab)
            WordBox.Items.Add(vocab)
            definitionList.Add(defin)
            exampleList.Add(example)

        Loop

    End Sub

    Private Sub DefineBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineBTN.Click
        If (WordBox.SelectedIndex = -1) Then
            Return
        End If
        DefinitionTB.Text = definitionList.ElementAt(WordBox.SelectedIndex())
        ExampleSentenceWorldList_RTB.Text = exampleList.ElementAt(WordBox.SelectedIndex())

    End Sub

    Private Sub RandomWordBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomWordBTN.Click
        randIndex = Rand(0, WordBox.Items.Count - 1)
        WordBox.SelectedIndex = randIndex
        DefineRandomTB.Text = ""
        RandomWordTB.Text = WordBox.Items(randIndex)
    End Sub

    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long
        Rand = Int((High - Low + 1) * Rnd()) + Low
    End Function

    Private Sub DefineRandomBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineRandomBTN.Click
        DefineRandomTB.Text = definitionList.ElementAt(randIndex)
        ExampleSentenceRTB.Text = exampleList.ElementAt(randIndex)
    End Sub

    Private Sub AddNewWordBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewWordBTN.Click
        'go through word list to make sure the word is not repeating

        For i As Integer = 0 To wordList.Count - 1 Step 1
            If (NewWordTB.Text = wordList(i)) Then
                AddWordLastStatusL.Text = "Word already exists"
                Return
            End If
        Next

        wordList.Add(NewWordTB.Text)
        definitionList.Add(NewWordDefTB.Text)
        exampleList.Add(ExampleSentenceTB.Text)

        fileReader.Close()

        'write the new word to text file
        openFileWrite()
        fileWriter.WriteLine(NewWordTB.Text + "," + NewWordDefTB.Text + "<" + ExampleSentenceTB.Text + ">")
        fileWriter.Close()

        openFileRead()

        parseVocabFile(fileReader)

        NewWordTB.Text = ""
        NewWordDefTB.Text = ""
        AddWordLastStatusL.Text = "Added Successfully (current # words: " + wordList.Count.ToString + ")"
        NewWordTB.Focus()

    End Sub


    Private Sub NewWordDefTB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            AddNewWordBTN_Click(sender, e)
        End If
    End Sub

    Private Sub TabPage3_ControlAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles TabPage3.ControlAdded
        Dim cntrlName As String
        cntrlName = e.Control.Name.ToString
        If (cntrlName.StartsWith("CrossWordMtrxTB")) Then
            crossWordMatrix.Add(e.Control)
        End If
    End Sub

    Private Sub ReverseRandomWordBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReverseRandomWordBTN.Click
        randIndex = Rand(0, WordBox.Items.Count - 1)
        WordBox.SelectedIndex = randIndex
        ReverseWordTB.Text = ""
        ReverseRandomWordTB.Text = definitionList(randIndex)
    End Sub

    Private Sub ReverseBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReverseBTN.Click
        ReverseWordTB.Text = WordBox.Items(randIndex)
    End Sub

    Private Sub getEtymologyOnline(ByVal word As String)
        urlResult = WebRequest.Create(etymologyURL + word)
        objStream = urlResult.GetResponse.GetResponseStream()
    End Sub

    Private Sub getSampleSentenceOnline(ByVal word As String)
        urlResult = WebRequest.Create(sampleSentenceURL + word)
        objStream = urlResult.GetResponse.GetResponseStream()
    End Sub

    Private Sub onlineLookupThreadProc()
        Dim htmlTxt As String
        Do
            'getEtymologyOnline(getEtymologyList(etymologyIndex))
            ' Dim objReader As New StreamReader(objStream)
            ' htmlTxt = objReader.ReadToEnd()
            Thread.Sleep(1000)
        Loop
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
