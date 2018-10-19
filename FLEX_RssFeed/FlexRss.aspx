<?xml version="1.0" encoding="UTF-8" ?>
<%@ Page ContentType="text/xml" Language="VB" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="MySql.Data.MySqlClient" %>

<script runat="Server">
    Public Sub Page_Load(sender As Object, e As EventArgs)

           Dim Builder = New MySqlConnectionStringBuilder()
            ' データベースに接続するために必要な情報をBuilderに与える
            Builder.Server = "localhost"
            Builder.Port = 25565
            Builder.UserID = "toyo"
            Builder.Password = "yanagi"
            Builder.Database = "flex大成外環大泉"
            Builder.ConnectionTimeout = 600
            Builder.DefaultCommandTimeout = 300

            Dim ConStr = Builder.ToString()


        Dim con As New MySqlConnection
        con.ConnectionString = ConStr
        con.Open()
        ' contentsテーブルから最近の記事10件に関する「URL」を
        ' 取得し、Repeaterコントロールlinkにバインド
        Dim cmd As New MySqlCommand("SELECT * FROM flexイベントデータ ORDER BY ID DESC LIMIT 0,1", con)
        Dim objLnk_Rd As MySqlDataReader=cmd.ExecuteReader()
        link.DataSource = objLnk_Rd
        link.DataBind()
        objLnk_Rd.Close()
        ' contentsテーブルから最近の記事10件に関する「詳細情報」を
        ' 取得し、Repeaterコントロールrssにバインド
        Dim objItem As New MySqlCommand("SELECT * FROM flexイベントデータ ORDER BY ID DESC LIMIT 0,1", con)
        Dim objItem_Rd AS MySqlDataReader=objItem.ExecuteReader()
        rss.DataSource = objItem_Rd
        rss.DataBind()
        objItem_Rd.Close()
        con.Close()
    End Sub
</script>
<rdf:RDF xmlns="http://purl.org/rss/1.0/"
  xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#"
  xmlns:dc="http://purl.org/dc/elements/1.1/" xml:lang="ja">
  <channel rdf:about="http://www.wings.msn.to/">
    <title>FLEX</title>
    <description>FLEX</description>
    <link></link>
    <items>
      <rdf:Seq>
        <asp:Repeater id="link" runat="Server">
          <ItemTemplate>
            <rdf:li
              rdf:resource="<%# DataBinder.Eval(Container.DataItem, "イベントデータ") %>"
            />
          </ItemTemplate>
        </asp:Repeater>
      </rdf:Seq>
    </items>
  </channel>
  <image rdf:about="http://www.wings.msn.to/image/wings.jpg">
    <title>FLEX</title>
    <url></url>
    <link></link>
  </image>
  <asp:Repeater id="rss" runat="Server">
    <ItemTemplate>
      <item rdf:about="<%# DataBinder.Eval(Container.DataItem, "ID") %>">
        <title><%# DataBinder.Eval(Container.DataItem, "ID") %></title>
        <link><%# DataBinder.Eval(Container.DataItem, "TIME") %></link>
        <description>
          <%# DataBinder.Eval(Container.DataItem, "イベントデータ") %></description>
        <category>
          <%# DataBinder.Eval(Container.DataItem, "イベント種類") %></category>
        <dc:creator />
        <dc:date><%# DataBinder.Eval(Container.DataItem, "TIME", "{0:s}") %></dc:date>
      </item>
    </ItemTemplate>
  </asp:Repeater>
</rdf:RDF>