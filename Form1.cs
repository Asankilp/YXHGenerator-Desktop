using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YXHGenerator_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void generate1_Click(object sender, EventArgs e)
        {
            String mastervar1 = master1.Text; //事件主体
            String eventvar1 = event1.Text; //事件
            String reasonvar1 = reason1.Text; //解释
            output1.Text = "\t" + mastervar1 + eventvar1 + "是怎么回事呢？" + mastervar1 + "相信大家都很熟悉，但是" + mastervar1 + eventvar1 + "是怎么回事呢，下面就让小编带大家一起了解吧。"
                + mastervar1 + eventvar1 + "，其实就是" + reasonvar1 + "。大家可能会很惊讶，" + mastervar1 + "怎么会" + eventvar1 + "呢？但事实就是这样，小编也感到非常惊讶。"
                + "这就是关于" + mastervar1 + eventvar1 + "的事情了，大家有什么想法呢，欢迎在评论区告诉小编一起讨论哦！";
        }

        private void generate2_Click(object sender, EventArgs e)
        {
            String channelvar1;
            channelvar1 = channel1.Text; //频道名
            String countryvar1_1;
             countryvar1_1 = country1_1.Text;  //第一国籍
            String eventvar2_1 = event2_1.Text; //具体事件
            String guochengvar1 = guocheng1.Text; //具体过程
            String eventvar2_2 = event2_2.Text; //简略事件
            String countryvar1_2;
            countryvar1_2 = country1_2.Text;//第二国籍

            output2.Text = "\t" + "大家好，这里是" + channelvar1 + "，近日，一位" + countryvar1_1 + "小哥" + eventvar2_1 + "，让我们来看看他是怎么做的吧。"
            + "可以看见，他" + guochengvar1 + "，这样就完成了整个" + eventvar2_2 + "的过程，大家是不是非常惊讶？" + countryvar1_1 + "小哥简直太厉害了，轻松做到了" + eventvar2_2 + "，就连小编也感到特别惊讶。"
            + "大家还想再看到更多关于" + countryvar1_2 + "小哥的有趣的事情吗？欢迎订阅我的频道。我是" + channelvar1 + "，我们下期再见！";
        }
    }
}
