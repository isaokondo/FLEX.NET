﻿Public NotInheritable Class SplashScreen

    'TODO: このフォームは、プロジェクト デザイナー ([プロジェクト] メニューの下の [プロパティ]) の [アプリケーション] タブを使用して、
    '  アプリケーションのスプラッシュ スクリーンとして簡単に設定することができます


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'アプリケーションのアセンブリ情報に従って、ランタイムにダイアログ テキストを設定します。  


        'アプリケーション タイトル
        If My.Application.Info.Title <> "" Then
            'ApplicationTitle.Text = My.Application.Info.Title
        Else
            'アプリケーション タイトルがない場合は、拡張子なしのアプリケーション名を使用します
            'ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)my
        End If

        'デザイン時に書式設定文字列としてバージョン管理で設定されたテキストを使用して、バージョン情報の書式を
        '  設定します。これにより効率的なローカリゼーションが可能になります。
        '  ビルドおよび リビジョン情報は、次のコードを使用したり、バージョン管理のデザイン時のテキストを 
        '  "Version {0}.{1:  00}.{2}.{3}" のように変更したりすることによって含めることができます。
        '  詳細については、ヘルプの String.Format() を参照してください。
        '
        Version.Text += GetVersionNo()

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        '著作権情報
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
