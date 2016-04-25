Public Class Form1
    '
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub
    '
    Dim RandomClass As New Random()
    Dim SwitchTable()() As String =
    {
         ({"282", "604", "787"}), ({"001", "065", "270"}), ({"306", "994", "626"}), ({"704", "772", "539"}),
         ({"404", "064", "831"}), ({"241", "489", "026"}), ({"415", "453", "217"}), ({"904", "080", "892"}),
         ({"770", "540", "745"}), ({"746", "662", "621"}), ({"804", "672", "038"}), ({"697", "847", "021"}),
         ({"057", "471", "387"}), ({"454", "508", "580"}), ({"311", "838", "433"}), ({"691", "563", "022"}),
         ({"868", "968", "144"}), ({"660", "797", "120"}), ({"972", "762", "980"}), ({"549", "089", "531"}),
         ({"003", "841", "230"}), ({"628", "141", "852"}), ({"832", "880", "739"}), ({"834", "873", "281"}),
         ({"992", "911", "002"}), ({"367", "275", "176"}), ({"405", "532", "361"}), ({"516", "523", "303"}),
         ({"382", "332", "386"}), ({"121", "639", "698"}), ({"917", "092", "294"}), ({"168", "982", "360"}),
         ({"114", "412", "935"}), ({"884", "861", "597"}), ({"236", "295", "019"}), ({"560", "820", "006"}),
         ({"729", "046", "448"}), ({"584", "675", "328"}), ({"813", "870", "364"}), ({"330", "072", "612"}),
         ({"163", "219", "251"}), ({"827", "165", "857"}), ({"641", "929", "665"}), ({"435", "552", "221"}),
         ({"517", "266", "643"}), ({"316", "279", "844"}), ({"687", "940", "206"}), ({"315", "815", "427"}),
         ({"459", "239", "504"}), ({"197", "743", "513"}), ({"703", "839", "366"}), ({"170", "679", "475"}),
         ({"776", "287", "450"}), ({"651", "757", "717"}), ({"825", "410", "686"}), ({"309", "421", "031"}),
         ({"319", "744", "526"}), ({"235", "859", "184"}), ({"212", "444", "948"}), ({"172", "930", "193"}),
         ({"678", "822", "260"}), ({"937", "984", "139"}), ({"890", "126", "313"}), ({"135", "769", "684"}),
         ({"671", "722", "215"}), ({"499", "874", "525"}), ({"431", "458", "976"}), ({"424", "264", "851"}),
         ({"413", "151", "650"}), ({"049", "276", "977"}), ({"372", "371", "007"}), ({"962", "577", "974"}),
         ({"975", "611", "664"}), ({"692", "655", "194"}), ({"460", "645", "105"}), ({"202", "775", "333"}),
         ({"738", "356", "399"}), ({"936", "894", "511"}), ({"564", "204", "237"}), ({"322", "957", "883"}),
         ({"634", "200", "939"}), ({"011", "088", "816"}), ({"575", "225", "895"}), ({"473", "872", "042"}),
         ({"879", "063", "711"}), ({"442", "468", "535"}), ({"589", "045", "500"}), ({"622", "587", "882"}),
         ({"725", "068", "636"}), ({"630", "478", "693"}), ({"180", "043", "396"}), ({"169", "023", "481"}),
         ({"103", "551", "781"}), ({"488", "501", "232"}), ({"491", "335", "524"}), ({"083", "452", "919"}),
         ({"790", "737", "938"}), ({"600", "506", "614"}), ({"988", "250", "128"}), ({"186", "814", "107"}),
         ({"578", "681", "096"}), ({"368", "995", "780"}), ({"111", "119", "713"}), ({"334", "229", "826"}),
         ({"441", "106", "012"}), ({"439", "707", "283"}), ({"140", "210", "701"}), ({"390", "463", "913"}),
         ({"764", "254", "304"}), ({"696", "171", "893"}), ({"109", "599", "477"}), ({"388", "327", "143"}),
         ({"766", "485", "661"}), ({"742", "297", "408"}), ({"771", "989", "457"}), ({"271", "732", "632"}),
         ({"973", "498", "760"}), ({"289", "545", "747"}), ({"487", "338", "933"}), ({"758", "124", "818"}),
         ({"619", "945", "418"}), ({"256", "888", "381"}), ({"941", "008", "921"}), ({"085", "292", "570"}),
         ({"965", "245", "377"}), ({"243", "571", "269"}), ({"365", "495", "082"}), ({"091", "624", "544"}),
         ({"878", "147", "958"}), ({"538", "342", "017"}), ({"510", "494", "943"}), ({"179", "920", "926"}),
         ({"490", "150", "876"}), ({"723", "383", "010"}), ({"185", "676", "694"}), ({"588", "131", "081"}),
         ({"521", "479", "009"}), ({"218", "828", "380"}), ({"595", "100", "059"}), ({"402", "905", "583"}),
         ({"350", "761", "677"}), ({"720", "582", "146"}), ({"900", "378", "324"}), ({"110", "052", "307"}),
         ({"086", "331", "603"}), ({"705", "244", "451"}), ({"702", "971", "284"}), ({"891", "528", "108"}),
         ({"188", "376", "480"}), ({"666", "741", "902"}), ({"606", "727", "160"}), ({"561", "810", "029"}),
         ({"375", "472", "044"}), ({"037", "203", "572"}), ({"613", "627", "192"}), ({"258", "695", "354"}),
         ({"550", "079", "290"}), ({"034", "609", "353"}), ({"351", "863", "649"}), ({"953", "159", "546"}),
         ({"394", "542", "117"}), ({"581", "925", "608"}), ({"255", "811", "302"}), ({"438", "190", "426"}),
         ({"951", "113", "447"}), ({"558", "071", "227"}), ({"116", "167", "298"}), ({"586", "055", "305"}),
         ({"593", "385", "829"}), ({"133", "987", "507"}), ({"445", "690", "735"}), ({"161", "574", "329"}),
         ({"505", "753", "339"}), ({"979", "238", "216"}), ({"625", "801", "862"}), ({"299", "710", "054"}),
         ({"970", "074", "466"}), ({"122", "934", "272"}), ({"060", "559", "554"}), ({"209", "257", "391"}),
         ({"856", "291", "674"}), ({"768", "158", "177"}), ({"369", "594", "949"}), ({"278", "094", "798"}),
         ({"866", "750", "533"}), ({"543", "429", "617"}), ({"363", "014", "004"}), ({"947", "854", "998"}),
         ({"843", "967", "078"}), ({"154", "886", "782"}), ({"288", "683", "189"}), ({"423", "700", "682"}),
         ({"318", "496", "484"}), ({"728", "312", "252"}), ({"817", "557", "076"}), ({"842", "411", "924"}),
         ({"036", "718", "293"}), ({"803", "836", "927"}), ({"162", "912", "148"}), ({"569", "522", "840"}),
         ({"670", "341", "942"}), ({"903", "653", "393"}), ({"590", "657", "644"}), ({"434", "486", "605"}),
         ({"061", "615", "174"}), ({"142", "134", "286"}), ({"414", "778", "910"}), ({"343", "268", "736"}),
         ({"923", "406", "899"}), ({"032", "273", "062"}), ({"145", "714", "610"}), ({"635", "846", "740"}),
         ({"153", "359", "461"}), ({"914", "573", "802"}), ({"474", "075", "070"}), ({"877", "358", "104"}),
         ({"347", "885", "156"}), ({"425", "806", "812"}), ({"136", "853", "047"}), ({"618", "638", "993"}),
         ({"562", "093", "807"}), ({"277", "181", "436"}), ({"809", "199", "763"}), ({"579", "954", "565"}),
         ({"095", "981", "784"}), ({"166", "576", "234"}), ({"384", "242", "476"}), ({"601", "805", "688"}),
         ({"663", "966", "808"}), ({"821", "497", "858"}), ({"449", "708", "756"}), ({"024", "138", "568"}),
         ({"793", "137", "640"}), ({"355", "631", "783"}), ({"208", "041", "443"}), ({"792", "340", "991"}),
         ({"765", "222", "898"}), ({"196", "864", "529"}), ({"922", "129", "656"}), ({"348", "865", "654"}),
         ({"794", "755", "416"}), ({"946", "585", "392"}), ({"464", "721", "422"}), ({"018", "040", "652"}),
         ({"889", "685", "837"}), ({"201", "228", "285"}), ({"462", "101", "777"}), ({"567", "997", "455"}),
         ({"502", "850", "152"}), ({"503", "547", "066"}), ({"025", "906", "097"}), ({"467", "005", "715"}),
         ({"637", "073", "623"}), ({"616", "417", "978"}), ({"373", "020", "389"}), ({"800", "249", "824"})
    }
    Dim CompressionTable()() As String =
    {
         ({"!", "26"}), ({"@", "38"}), ({"#", "15"}), ({"$", "43"}),
         ({"    ", "48"}), ({"^", "25"}), ({"&", "49"}), ({"*", "16"}),
         ({"(", "57"}), ({")", "64"}), ({"_", "65"}), ({"-", "37"}),
         ({"+", "70"}), ({"=", "75"}), ({"q", "66"}), ({"w", "14"}),
         ({"e", "80"}), ({"r", "42"}), ({"t", "74"}), ({"y", "81"}),
         ({"u", "24"}), ({"i", "47"}), ({"o", "56"}), ({"p", "82"}),
         ({"[", "84"}), ({"]", "39"}), ({"/", "62"}), ({"a", "63"}),
         ({"s", "36"}), ({"d", "50"}), ({"f", "23"}), ({"g", "69"}),
         ({"h", "85"}), ({"j", "86"}), ({"k", "92"}), ({"l", "13"}),
         ({";", "51"}), ({"'", "91"}), ({"z", "77"}), ({"x", "73"}),
         ({"c", "76"}), ({"v", "52"}), ({"b", "87"}), ({"n", "10"}),
         ({"m", "83"}), ({",", "40"}), ({".", "28"}), ({"Q", "27"}),
         ({"W", "88"}), ({"E", "12"}), ({"R", "89"}), ({"T", "11"}),
         ({"Y", "58"}), ({"U", "31"}), ({"I", "79"}), ({"O", "17"}),
         ({"P", "41"}), ({"{", "32"}), ({"}", "46"}), ({"|", "18"}),
         ({"A", "53"}), ({"S", "44"}), ({"D", "19"}), ({"F", "67"}),
         ({"G", "72"}), ({"H", "33"}), ({"J", "54"}), ({"K", "34"}),
         ({"L", "78"}), ({":", "68"}), ({"`", "55"}), ({"Z", "29"}),
         ({"X", "30"}), ({"C", "61"}), ({"V", "21"}), ({"B", "59"}),
         ({"N", "45"}), ({"M", "60"}), ({"<", "20"}), ({">", "35"}),
         ({"?", "22"}), ({" ", "90"}), ({"~", "71"}), ({"\", "00"})
    }
    'in this table here you need to manually adjust the RIGHT values, don't tough the left ones, the right ones are in HEX
    Dim SCTxk()() As String =
    {
        ({"G", "11"}),
        ({"H", "22"}),
        ({"I", "33"}),
        ({"J", "44"}),
        ({"K", "55"}),
        ({"L", "66"}),
        ({"M", "77"}),
        ({"N", "88"}),
        ({"O", "99"}),
        ({"P", "AA"}),
        ({"Q", "BB"}),
        ({"R", "CC"}),
        ({"S", "DD"}),
        ({"T", "FF"}),
        ({"U", "13"}),
        ({"V", "25"}),
        ({"W", "37"}),
        ({"X", "49"}),
        ({"Y", "51"}),
        ({"Z", "63"})
    }
    Function DecimalFromChar(ByVal argument As Char) As Integer
        DecimalFromChar = Decimal.op_Implicit(argument)
    End Function
    Function encode(ByVal input As String) As String
        Dim TempString As String = ""
        If String.IsNullOrEmpty(input) = True Then
            encode = TempString
            Exit Function
        End If
        For index As UInt64 = 0 To input.Length() - 1 Step 1
            TempString = TempString + SwitchTable(DecimalFromChar(input.Chars(index)))(RandomClass.Next(0, 3))
        Next index
        encode = TempString
    End Function
    Function decode(ByVal input As String) As String
        Dim TempString As String = ""
        Dim OS As String = ""

        If String.IsNullOrEmpty(input) = True Then
            decode = TempString
            Exit Function
        End If
        ' If input.Length() Mod 3 = 0 Then
        '
        'Else
        '    decode = TempString
        '    MsgBox("This is not a valid hash!", MsgBoxStyle.OkOnly, "Error")
        '    Exit Function
        'End If
        For index As UInt64 = 0 To input.Length() - 1 Step 1
            If IsNumeric(input(index)) = False Then
                decode = TempString
                MsgBox("This is not a valid hash! " + index.ToString + " " + input(index).ToString, MsgBoxStyle.OkOnly, "Error")
                Exit Function
            End If
        Next index
        For index As UInt64 = 0 To input.Length() - 1 Step 3
            OS = input(index).ToString + input(index + 1).ToString + input(index + 2).ToString
            For a As Integer = 0 To 255 Step 1
                If SwitchTable(a)(0) = OS Then
                    TempString = TempString + Chr(a)
                ElseIf SwitchTable(a)(1) = OS Then
                    TempString = TempString + Chr(a)
                ElseIf SwitchTable(a)(2) = OS Then
                    TempString = TempString + Chr(a)
                End If
            Next a
        Next index
        decode = TempString
    End Function
    Function compress(ByVal input As String) As String
        Dim TempString As String = input
        For index As Integer = 0 To 83 Step 1
            TempString = Replace(TempString, CompressionTable(index)(1), CompressionTable(index)(0))
        Next index
        compress = TempString
    End Function
    Function decompress(ByVal input As String) As String
        Dim TempString As String = input
        TempString = Replace(TempString, vbNewLine, "")
        For index As Integer = 0 To 83 Step 1
            TempString = Replace(TempString, CompressionTable(index)(0), CompressionTable(index)(1))
        Next index
        decompress = TempString
    End Function
    Function CSIMPLE(ByVal input As String) As String
        Dim TempString As String = input
        For index As Integer = 0 To 19 Step 1
            TempString = Replace(TempString, SCTxk(index)(1), SCTxk(index)(0))
        Next index
        CSIMPLE = TempString
    End Function
    Function DSIMPLE(ByVal input As String) As String
        Dim TempString As String = input
        TempString = Replace(TempString, vbNewLine, "")
        TempString = Replace(TempString, vbCrLf, "")
        TempString = Replace(TempString, vbLf, "")
        TempString = Replace(TempString, vbCr, "")
        For i As Integer = 0 To 47 Step 1
            TempString = Replace(TempString, Chr(i), "")
        Next
        For i As Integer = 58 To 64 Step 1
            TempString = Replace(TempString, Chr(i), "")
        Next
        For i As Integer = 91 To 255 Step 1
            TempString = Replace(TempString, Chr(i), "")
        Next

        For index As Integer = 0 To 19 Step 1
            TempString = Replace(TempString, SCTxk(index)(0), SCTxk(index)(1))
        Next index
        'MsgBox(TempString)
        DSIMPLE = TempString
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
    Public Function StrToHex(ByVal Copy As String) As String
        Dim sVal As String = ""
        Dim sHex As String = ""
        Dim Data As String = Copy
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1, Data.Length - 1)
            sHex = sHex & sVal
        End While
        Return sHex
    End Function
    Public Function HexToStr(ByVal Copy As String) As String
        Dim sVal As String = ""
        Dim sHex As String = ""
        Dim Data As String = Copy
        While Data.Length > 0
            sVal = Str(Convert.ToInt32(Data.Substring(0, 2).ToString(), 16))
            Data = Data.Substring(2, Data.Length - 2)
            sHex = sHex & Chr(sVal)
        End While
        Return sHex
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Str As String = encode(RichTextBox1.Text)
        'MsgBox(Str)
        'MsgBox(compress(Str))
        'MsgBox(StrToHex(compress(Str)))
        RichTextBox2.Text = CSIMPLE(StrToHex(compress(Str)))
        Dim counter As Integer = 0
        For i As Integer = 0 To 2147483647
            If i < RichTextBox2.TextLength Then
                counter += 1

                If counter = 69 Then
                    RichTextBox2.Text = RichTextBox2.Text.Insert(i, vbCrLf)
                    'RichTextBox2.Text = RichTextBox2.Text.Insert(i, Chr(12))
                    'RichTextBox2.Text = RichTextBox2.Text.Insert(i, Chr(15))
                    'i += 2
                    counter = 0
                End If
            Else
                Exit For
            End If
        Next
        If CheckBox1.Checked = True Then
            If RichTextBox2.TextLength > 0 Then
                Clipboard.Clear()
                Clipboard.SetText(RichTextBox2.Text)
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox2.Text = decode(decompress(HexToStr(DSIMPLE(RichTextBox1.Text))))
        If CheckBox1.Checked = True Then
            If RichTextBox2.TextLength > 0 Then
                Clipboard.Clear()
                Clipboard.SetText(RichTextBox2.Text)
            End If
        Else
            MsgBox(RichTextBox2.Text)
        End If
    End Sub
    Private Sub RichTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.Click
        If CheckBox3.Checked = True Then
            RichTextBox2.SelectAll()
        End If
    End Sub
    Private Sub RichTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.Click
        If CheckBox2.Checked = True Then
            RichTextBox1.SelectAll()
        End If
        If CheckBox4.Checked = True Then
            If String.IsNullOrEmpty(Clipboard.GetText()) = False Then
                RichTextBox1.Text = ""
                RichTextBox1.Text = Clipboard.GetText()
            End If
        End If
    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.ForeColor() = Color.Black
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = CheckBox5.Checked
    End Sub
End Class
