﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DevASPNET
{
    public partial class FrmPageLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 동적으로 페이지의 제목을 변경하는 세 가지 방법
            Title = "제목이 바뀝니다.";
            Page.Title = "제목이 출력됩니다.";
            Page.Header.Title = "Page 클래스";

            // 외부 스타일시트 정의
            HtmlLink objHtmlLink = new HtmlLink();
            objHtmlLink.Href = "DevASPNET.css";
            objHtmlLink.Attributes.Add("rel", "stylesheet");
            objHtmlLink.Attributes.Add("type", "text/css");

            // Header 태그 정의, 외부스타일과 메타태그 등록
            HtmlHead objHtmlHead = Page.Header;
            objHtmlHead.Controls.Add(objHtmlLink);

            // 동적으로 페이지에 스타일시트를 적용하는 방법
            Style objButtonStyle = new Style();
            objButtonStyle.ForeColor = System.Drawing.Color.Navy; // Color:Navy;
            objButtonStyle.Font.Size = 9; // font-size : 9
            objButtonStyle.Font.Name = "Verdana";
            Page.Header.StyleSheet.RegisterStyle(objButtonStyle, null);
            this.btnNewLoad.CssClass = objButtonStyle.RegisteredCssClass;
            this.btnPostBack.CssClass = objButtonStyle.RegisteredCssClass;

            Style objDivStyle = new Style();
            objDivStyle.ForeColor = System.Drawing.Color.Blue;
            objDivStyle.Font.Size = 9;
            objDivStyle.Font.Name = "Verdana";
            objDivStyle.Font.Italic = true;
            Page.Header.StyleSheet.CreateStyleRule(objDivStyle, null, "body, div");

            // 버튼을 클릭하면 [1][2]번 코드는 실행되지 않는다.
            if (!Page.IsPostBack)
            {
                Response.Write("[1] 폼이 처음 로드할 때에만 실행<br />");
            }

            if(Page.IsPostBack == false)
            {
                Response.Write("[2] 폼이 처음 로드할 때에만 실행<br />");
            }

            Response.Write("[3] 폼이 로드할 때마다 실행<br />");

        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            string strJs = @"
            <script>
                window.alert('포스트백 됨');
            </script>
            ";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", strJs);
        }

        protected void btnNewLoad_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmPageLoad.aspx");
        }
    }
}