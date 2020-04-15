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
            String channelvar1= channel1.Text; //频道名
            String countryvar1_1= country1_1.Text;  //第一国籍
            String eventvar2_1 = event2_1.Text; //具体事件
            String guochengvar1 = guocheng1.Text; //具体过程
            String eventvar2_2 = event2_2.Text; //简略事件
            String countryvar1_2 = country1_2.Text;//第二国籍

            output2.Text = "\t" + "大家好，这里是" + channelvar1 + "，近日，一位" + countryvar1_1 + "小哥" + eventvar2_1 + "，让我们来看看他是怎么做的吧。"
            + "可以看见，他" + guochengvar1 + "，这样就完成了整个" + eventvar2_2 + "的过程，大家是不是非常惊讶？" + countryvar1_1 + "小哥简直太厉害了，轻松做到了" + eventvar2_2 + "，就连小编也感到特别惊讶。"
            + "大家还想再看到更多关于" + countryvar1_2 + "小哥的有趣的事情吗？欢迎订阅我的频道。我是" + channelvar1 + "，我们下期再见！";
        }

        private void generate3_Click(object sender, EventArgs e)
        {
            String channelvar2;
            if (string.IsNullOrWhiteSpace(channel2.Text)) { channelvar2 = "营销号看世界"; } else { channelvar2 = channel2.Text; };//频道名2
            String realmvar1 = realm1.Text;//领域
            String looksvar1 = looks1.Text;//外观
            String itemvar1 = item1.Text;//物品
            String featuresvar1_1 = features1_1.Text;//功能
            String featuresvar1_2 = features1_2.Text;//简略功能
            output3.Text = "\t" + "大家好，我是" + channelvar2 + "，随着社会的发展，我国科技事业不断壮大，综合国力不断发展，取得了举世瞩目的成就，今天我们就来谈谈" + realmvar1 + "。"
                + "我国最近研发出了一款" + itemvar1 + ",它" + looksvar1 + "，" + featuresvar1_1 + "。大家可能会惊讶他能" + featuresvar1_2 + "呢，小编也是非常惊讶呢。"
                + "这就是关于" + itemvar1 + "的介绍了，如果想了解更多" + realmvar1 + "的事情，欢迎点赞收藏关注哦。";
        }
    }
}
