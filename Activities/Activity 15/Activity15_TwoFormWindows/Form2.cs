using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15_TwoFormWindows
{
    public partial class Form2 : Form
    {
        public Form2(string name, int luckNumber, int ultimateNumber, int destinyNumber, int lifeNumber)
        {
            InitializeComponent();

            label_Name.Text = "HERE ARE YOUR RESULTS "+name.ToUpper()+"!";
            label_LuckyNumber.Text = luckNumber.ToString();
            label_Ultimate.Text = ultimateNumber.ToString();

            //change based on the life number
            if(lifeNumber == 1)
            {
                label_lifepath.Text = "Those with Life Path Number 1 tend to be ambitious, individualistic, determined, and likely to take on a leader role in any venture. \nYou are likely more drawn to independent, creative and innovative pursuits. \nYou like the freedom to follow your own goals and be the boss when it comes to making any and all of your life decision. \nBe wary of overexerting yourself, and losing focus in your endeavours.";
            }
            if(lifeNumber == 2 || lifeNumber == 11)
            {
                label_lifepath.Text = "Those with Life Path Number 2 (or number 11 - which means highly sensitive) tend to be sensitive, intuitive, reserved and on the shy side. \nYou are likely more drawn to quiet and relaxing atmospheres, and try to avoid conflict in any situation. \nBecause of your perceptive and tactful nature, you are good at finding a balanced and peaceful resolution to conflicts. \nBe wary of being overly sensitive and touchy to the world and the people around you. \n[Number 11's - more spiritually aware, a visionary, inspiring, idealistic, and a deep thinker, and you rely on faith rather than logic.]";
            }
            if(lifeNumber == 3)
            {
                label_lifepath.Text = "Those with Life Path Number 3 tend to be charismatic, charming, and witty. \nYou are more expressive, upbeat, and creative, and more likely to be drawn to pursuits that will act as an outlet for your artistic talents. \nBe wary of losing concentration and not committing to your projects, as well as becoming disorganized with your responsibilities and money.";
            }
            if(lifeNumber == 4 || lifeNumber == 22)
            {
                label_lifepath.Text = "Those with Life Path Number 4 (or number 22 - which means greater spiritual understanding, visionary) tend to be \ngood organizers, practical, diligent, and persistent in their approach to dealing with day to day activities. \nYou are a realist, and your down to earth nature, decisive actions, and perseverance, all make you that much more likely to \nsucceed where others may fail. \nBe wary of being too stubborn, rigid, and even becoming a workaholic.";
            }
            if (lifeNumber == 5)
            {
                label_lifepath.Text = "Those with Life Path Number 5 tend to be adventurous and free spirited people. \nYou are much more likely to crave change and new life experiences. \nBecause of your upbeat personality, you are likely to motivate others. \nYour curious, flexible, and impulsive nature will draw you towards travel and other exiting pursuits. \nBe wary of overstretching yourself, of overreaching in your search for freedom.";
            }
            if (lifeNumber == 6 || lifeNumber ==33)
            {
                label_lifepath.Text = "Those with Life Path Number 6 (or number 33- which means a very nurturing and responsible) tend to be the healers of our society. \nBecause of your loving, compassionate, and responsible nature, you are likely to find yourself following endeavours that \ninvolve helping those who are weak, and less fortunate. \nBe wary and of becoming overburdened by those seeking a helping hand or a shoulder to cry on, also be mindful of not recognizing \nthat the help and assistance you think you are providing to others can also be seen as too smothering and interfering.";
            }
            if (lifeNumber == 7)
            {
                label_lifepath.Text = "Those with Life Path Number 7 tend to be intellectual and analytical thinkers. \nYou likely have a great understanding of the spiritual self and are drawn to the mysteries of the very existence of all that is in the universe and \neverything within it. \nYou are more independent, and tend to withdraw into your own solitary world to contemplate on your current projects. \nBe wary of becoming too narrow minded and reclusive.";
            }
            if (lifeNumber == 8)
            {
                label_lifepath.Text = "Those with Life Path Number 8 tend to be natural leaders, rather than followers, with a good capacity to visualize, and an intuitive ability \nto know, what needs to be done in order to accomplish the task at hand. \nAs such you are more likely to find yourself being more successful with money, in business, or politics. \nBe wary of losing site of your compassion, and becoming too ambitious and greedy in the pursuit of your goals.";
            }
            if (lifeNumber == 9)
            {
                label_lifepath.Text = " Those with Life Path Number 9 tend to have a humanitarian, and almost a utopian quality to their very being. \nBecause of your compassionate, philanthropical nature, you are likely to be drawn toward global issues that deal with helping the whole \nof human kind, and the world. \nBe wary of overextending yourself, of sacrificing too much of yourself, and of losing the greater perspective in the pursuit of your goals.";
            }

            //change based on destiny number
            if (destinyNumber == 1)
                label_destiny.Text = "The 1 Expression Number indicates you are independent and individualistic. \nIt represents the risk taker and a pioneering spirit. \nSelf-reliant, confident, and perhaps sometimes overly opinionated, you are more likely to try the untested and new things. \nYou like the freedom to choose your path and make your own decisions. \nBe wary of being overly competitive, and too self-centered and critical of others.";
            if (destinyNumber == 2 || destinyNumber == 11)
                label_destiny.Text = "The 2 /11 Expression Number indicates you are more intuitive and sensitive to the world and the people around you. \nYou are more likely to crave balance and peaceful resolution to conflict, which makes you better equipped to work and deal with others. \nBe wary of being thrown off balance by negative people or situations around you.";
            if (destinyNumber == 3)
                label_destiny.Text = "The 3 Expression Number indicates you tend to be outgoing, with a more uplifting and optimistic energy than others. \nYou are a creative spirit and likely more drawn to the Arts, or other similar outlets where your energy can be focused on bringing forth \nthat which is in your imagination. \nBe wary of becoming too cynical, irresponsible, and undisciplined, as this will hinder progress in your creative ventures.";
            if (destinyNumber == 4 || destinyNumber == 22)
                label_destiny.Text = "The 4 /22 Expression Number is one of a builder. You are more grounded, methodical, and practical. \nBecause you are likely more drawn to order and stability, you tend to be more reliable and responsible, and as such, are often seen as \nthe bedrock of your family or business. \nBe wary of getting stuck on overly small details, and being too stubborn or rigid.";
            if (destinyNumber == 5)
                label_destiny.Text = "The 5 Expression Number indicates your love of freedom, excitement and new experiences. \nYou are more of a free spirit, eager to explore and try new things. \nYou tend to be very adaptable, hating the 'routine' and not follow the social norms. \nBe wary of changing your mind too often, of getting bored too quickly, and leaving whatever the job or project at hand unfinished.";
            if (destinyNumber == 6 || destinyNumber == 33)
                label_destiny.Text = "The 6 /33 Expression Number indicates you are loving and honest, and as such you often play the role of healer or counselor. \nYou have a tendency to put the need of others before yourself, and often feel the need to sacrifice your time and yourself to take care of others. \nBe wary of being too overprotective, meddling into other peoples' affairs, and not giving those you care about their own personal space.";
            if (destinyNumber == 7)
                label_destiny.Text = "The 7 Expression Number indicates you are inquisitive, intelligent, and have a yearning to attain \ntruth, knowledge, and wisdom in all aspects of what is the very essence of existence. \nYou are likely to be more introverted and require your own space and alone time to pursue your own projects. \nBe wary of becoming too secretive, cynical, and cutting yourself off from those around you.";
            if (destinyNumber == 8)
                label_destiny.Text = "The 8 Expression Number indicates you are ambitious, disciplined, and hard working. \nThese qualities, along with being a good and efficient planner, and a tendency to see things the way they truly are, often result in great \nsuccess in whatever field you choose to work in. \nBe wary of being too stubborn and intolerant of others, and try to keep the right balance in all your pursuits.";
            if (destinyNumber == 9)
                label_destiny.Text = "The 9 Expression Number indicates you tend to be drawn to causes and endeavours with a purpose to make the world a better place. \nIdealistic, a humanitarian, and a visionary, you can inspire others to help you achieve the greater good. \nBe wary of craving validation for your work, and being taken advantage of by those who do not see the world as you do.";
            
        }
    }
}
