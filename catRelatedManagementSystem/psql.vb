Imports Npgsql
Imports Newtonsoft.json.Linq
Imports System.IO

Module psql

    Public pgsqlCon As New NpgsqlConnection
    Public sqlCommand As New NpgsqlCommand

    'データベースに接続
    Sub sqlSt()

        Dim conStr As String = GetConnectionString("appsettings.json", "ConnectionStrings:PostgreSqlConnection")
        pgsqlCon.ConnectionString = conStr
        pgsqlCon.Open()

    End Sub

    'データベースの切断
    Sub sqlCl()
        pgsqlCon.Close()
    End Sub

    'データセットを返す処理
    Function sqlResultReturn(ByVal query As String) As DataTable

        Dim dt As New DataTable()

        Try
            'データ取得のためのアダプタ設定
            Dim adapter = New NpgsqlDataAdapter(query, pgsqlCon)

            'データ取得
            adapter.Fill(dt)
            Return dt

        Catch ex As Exception

            Return dt

        End Try

    End Function

    'データセットを返さない処理
    Function sqlResultNo(ByVal query As String)

        Try
            sqlCommand.Connection = pgsqlCon
            sqlCommand.CommandText = query
            sqlCommand.ExecuteNonQuery()

            Return "Complete"

        Catch ex As Exception

            Return ex.Message

        End Try

    End Function
    '設定ファイルから接続情報を取得
    Private Function GetConnectionString(ByVal filePath As String, ByVal key As String) As String
        Try
            If Not File.Exists(filePath) Then
                MessageBox.Show("設定ファイルが見つかりません: " & filePath)
                Return Nothing
            End If
            Dim json As String = File.ReadAllText(filePath)
            Dim jObject As JObject = JObject.Parse(json)
            Dim connectionString As String = jObject.SelectToken(key.Replace(":", "."))?.ToString()

            If connectionString Is Nothing Then
                MessageBox.Show("接続文字列が見つかりません: " & key)
                Return Nothing
            End If

            Return connectionString
        Catch ex As Exception
            MessageBox.Show("設定ファイルの読み込みに失敗しました: " & ex.Message)
            Return Nothing
        End Try
    End Function



    '接続確認
    Sub CheckConnection()
        Try
            Dim conStr As String = GetConnectionString("appsettings.json", "ConnectionStrings:PostgreSqlConnection")
            pgsqlCon.ConnectionString = conStr
            pgsqlCon.Open()
            MessageBox.Show("接続に成功しました。")
        Catch ex As Exception
            MessageBox.Show("接続に失敗しました: " & ex.Message)
        Finally
            pgsqlCon.Close()
        End Try

    End Sub

End Module