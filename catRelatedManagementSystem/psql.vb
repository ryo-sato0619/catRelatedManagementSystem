Imports Npgsql
Module psql

    Public pgsqlCon As New NpgsqlConnection
    Public sqlCommand As New NpgsqlCommand

    'データベースに接続
    Sub sqlSt()

        Dim Builder = New NpgsqlConnectionStringBuilder()
        'データベースに必要な情報を取得
        Builder.Host = "localhost"
        Builder.Port = 5432
        Builder.Username = "postgres"
        Builder.Password = "test"
        Builder.Database = "postgres"

        Dim conStr = Builder.ToString()

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
            Dim Ds As New DataSet
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

    Sub CheckConnection()
        Try
            pgsqlCon.ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=test;Database=postgres"
            pgsqlCon.Open()
            MessageBox.Show("接続に成功しました。")
        Catch ex As Exception
            MessageBox.Show("接続に失敗しました: " & ex.Message)
        Finally
            pgsqlCon.Close()
        End Try

    End Sub

End Module