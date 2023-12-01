﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmCommandControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 레이블의 배경색 변경
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
        }

        protected void btnCommand_Click(object sender, EventArgs e)
        {
            // sender(전달자) : 현재 이벤트핸들러를 호출한 객체(이름으로 접근 가능)
            if(sender == btnButton)
            {
                this.lblDisplay.Text = "버튼 클릭됨.";
            }
            else if(sender == btnLink)
            {
                this.lblDisplay.Text = "링크버튼 클릭됨.";
            }
        }


        protected void btnImage_Click(object sender, ImageClickEventArgs e)
        {
            // XXXEventArgs 클래스형 매개 변수는 현재 시점에서 필요한 추가 정보 제공
            // 클릭된 이미지의 좌표 클릭
            this.lblDisplay.Text = $"이미지 버튼 클릭됨.<br /> X좌표: {e.X}, Y좌표: {e.Y}";

            // 해당 이미지의 가로 20픽셀, 세로 20픽셀 이상 클릭하면 이동
            if(e.X > 20 && e.Y > 20) // IE에 최적화
            {
                Response.Redirect("http://dotnetkorea.com/");
            }

        }
    }
}