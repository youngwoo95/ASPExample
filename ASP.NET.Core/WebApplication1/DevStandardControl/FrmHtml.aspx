﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmHtml.aspx.cs" Inherits="DevStandardControl.FrmHtml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>HTML 대체 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            하이퍼링크 :
            <a href="http://www.dotnetkorea.com/">닷넷코리아</a>
            <asp:HyperLink ID="lnkDotNetKorea" runat="server" NavigateUrl="http://dotnetkorea.com/">닷넷코리아</asp:HyperLink>
            <br />
            <br />

            
            <!---->
            <hr />
            이미지 :
            <img src="./images/kakao.jpeg" alt="홈으로..." title="홈으로..." />
            <asp:Image ID="imgHome" runat="server" ImageUrl="./images/kakao.jpeg" ToolTip="홈으로..." AlternateText="홈으로..." />
            <br />
            <br />

            <!---->
            <hr />
            이미지맵 :
            <img src="./images/kakao2.jpeg" border="0" usemap="#GoHome" />
            <map name="GoHome">
                <area shape="circle" coords="16, 16, 5" href="http://www.dotnetkorea.com/" alt="닷넷코리아" target="_blank" />
                <area shape="rect" coords="0,0,5,5" href="http://www.taeyo.net/" alt="테오닷넷" />
            </map>

            <asp:ImageMap ID="mapHome" runat="server" ImageUrl="./images/kakao2.jpeg">
                <asp:RectangleHotSpot AlternateText="테오닷넷" Bottom="5" HotSpotMode="Navigate" NavigateUrl="http://taeyo.net" Right="5" Target="_blank" />
                <asp:CircleHotSpot AlternateText="닷넷코리아" HotSpotMode="Navigate" NavigateUrl="http://dotentkorea.com/" Radius="5" Target="_blank" X="16" Y="16" />
            </asp:ImageMap>
            <br />

            <!---->
            <hr />
            테이블: <br />
            <table border="1">
                <tr>
                    <td>1행 1열 테이블</td>
                </tr>
            </table>

            <asp:Table ID="tblTable" runat="server" GridLines="Both">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" BackColor="Lime">1행 1열</asp:TableCell>
                    <asp:TableCell runat="server" BackColor="Yellow">1행 2열</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" BackColor="Blue">2행 1열</asp:TableCell>
                    <asp:TableCell runat="server" BackColor="Red">2행 2열</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />

            <!---->
            <hr />
            목록 :
            <ul>
                <li>C#</li>
                <li>ASP.NET</li>
            </ul>

            <asp:BulletedList ID="bulFavorite" runat="server" BulletStyle="UpperRoman">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>ASP.NET</asp:ListItem>
            </asp:BulletedList>

        </div>
    </form>
</body>
</html>
