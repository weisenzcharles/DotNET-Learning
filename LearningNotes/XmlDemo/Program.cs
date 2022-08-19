using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument xmlDocument = new XmlDocument();
            // 定义 xml 声明
            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "yes");

            xmlDocument.AppendChild(xmlDeclaration);

            var movieElement = xmlDocument.CreateElement("movie");

            var plotElement = xmlDocument.CreateElement("plot");
            XmlCDataSection xmlCDataSection = xmlDocument.CreateCDataSection("。");
           
            plotElement.AppendChild(xmlCDataSection);
            movieElement.AppendChild(plotElement);

            var outlineElement = xmlDocument.CreateElement("outline");
     
            movieElement.AppendChild(outlineElement);

            var lockdataElement = xmlDocument.CreateElement("lockdata");
            lockdataElement.InnerText = string.Format("{0}", "false");
            movieElement.AppendChild(lockdataElement);

            var dateaddedElement = xmlDocument.CreateElement("dateadded");
            dateaddedElement.InnerText = string.Format("{0}", "2021-04-15 19:57:42");
            movieElement.AppendChild(dateaddedElement);

            //<title>革命者</title>
            var titleElement = xmlDocument.CreateElement("title");
            titleElement.InnerText = string.Format("{0}", "革命者");
            movieElement.AppendChild(titleElement);

            //<originaltitle>革命者</originaltitle>
            var originaltitleElement = xmlDocument.CreateElement("originaltitle");
            originaltitleElement.InnerText = string.Format("{0}", "革命者");
            movieElement.AppendChild(originaltitleElement);

            //<actor>
            //  <name>张颂文</name>
            //  <type>Actor</type>
            //</actor>
            //<actor>
            //  <name>李易峰</name>
            //  <type>Actor</type>
            //</actor>
            string actors = "张颂文,李易峰";
            var actorList = actors.Split(',').ToList();
            foreach (var actor in actorList)
            {
                var actorElement = xmlDocument.CreateElement("actor");

                var nameElement = xmlDocument.CreateElement("name");
                nameElement.InnerText = string.Format("{0}", actor);
                actorElement.AppendChild(nameElement);

                var typeElement = xmlDocument.CreateElement("type");
                typeElement.InnerText = string.Format("{0}", "Actor");
                actorElement.AppendChild(typeElement);

                movieElement.AppendChild(actorElement);
            }

            //<year>2021</year>
            var yearElement = xmlDocument.CreateElement("year");
            yearElement.InnerText = string.Format("{0}", "2021");
            movieElement.AppendChild(yearElement);

            //<sorttitle></sorttitle>
            var sorttitleElement = xmlDocument.CreateElement("sorttitle");
            sorttitleElement.InnerText = string.Format("{0}", "革命者");
            movieElement.AppendChild(sorttitleElement);

            //<mpaa>G</mpaa>
            var mpaaElement = xmlDocument.CreateElement("mpaa");
            mpaaElement.InnerText = string.Format("{0}", "G");
            movieElement.AppendChild(mpaaElement);

            //<premiered>2021-07-01</premiered>
            var premieredElement = xmlDocument.CreateElement("dateadded");
            premieredElement.InnerText = string.Format("{0}", "2021-07-01");
            movieElement.AppendChild(premieredElement);

            //<releasedate>2021-07-01</releasedate>
            var releasedateElement = xmlDocument.CreateElement("releasedate");
            releasedateElement.InnerText = string.Format("{0}", "2021-07-01");
            movieElement.AppendChild(releasedateElement);

            //<runtime>34</runtime>
            var runtimeElement = xmlDocument.CreateElement("runtime");
            runtimeElement.InnerText = string.Format("{0}", "34");
            movieElement.AppendChild(runtimeElement);

            //<genre>历史</genre>
            //<genre>剧情</genre>
            string genres = "历史,剧情";
            var genresList = genres.Split(',').ToList();
            foreach (var genre in genresList)
            {
                var genreElement = xmlDocument.CreateElement("genre");
                genreElement.InnerText = string.Format("{0}", genre);
                movieElement.AppendChild(genreElement);
            }
            //<studio>北京光线影业有限公司</studio>
            var studioElement = xmlDocument.CreateElement("studio");
            studioElement.InnerText = string.Format("{0}", "北京光线影业有限公司");
            movieElement.AppendChild(studioElement);


            //<uniqueid type="MovieScraper">tt14922172</uniqueid>
            var uniqueidElement = xmlDocument.CreateElement("uniqueid");
            uniqueidElement.SetAttribute("type", "MovieScraper");
            uniqueidElement.InnerText = string.Format("{0}", "tt14922172");
            movieElement.AppendChild(uniqueidElement);

            //<javscraperid></javscraperid>
            var javscraperidElement = xmlDocument.CreateElement("uniqueid");
            javscraperidElement.InnerText = string.Format("{0}", "tt14922172");
            movieElement.AppendChild(javscraperidElement);

            //<uniqueid type="MovieScraper-Json">{"OriginalTitle":"革命者","Cover":"https://img3.doubanio.com/view/photo/raw/public/p2666303410.jpg","Date":"2021-07-01"}</uniqueid>
            var jsonElement = xmlDocument.CreateElement("uniqueid");
            jsonElement.SetAttribute("type", "MovieScraper-Json");
            jsonElement.InnerText = string.Format("{0}", "{\"OriginalTitle\":\"" + "革命者" + "\",\"Cover\":\"" + "https://img3.doubanio.com/view/photo/raw/public/p2666303410.jpg" + "\",\"Date\":\"" + "2021-07-01" + "\"}");
            movieElement.AppendChild(jsonElement);

            //<moviescraper-jsonid>{"OriginalTitle":"革命者","Cover":"https://img3.doubanio.com/view/photo/raw/public/p2666303410.jpg","Date":"2021-07-01"}</moviescraper-jsonid>
            var jsonidElement = xmlDocument.CreateElement("moviescraper-jsonid");
            jsonidElement.InnerText = string.Format("{0}", "{\"OriginalTitle\":\"" + "革命者" + "\",\"Cover\":\"" + "https://img3.doubanio.com/view/photo/raw/public/p2666303410.jpg" + "\",\"Date\":\"" + "2021-07-01" + "\"}");
            movieElement.AppendChild(jsonidElement);

            //<uniqueid type="MovieScraper-Url">https://movie.douban.com/subject/35288767/</uniqueid>
            var urlElement = xmlDocument.CreateElement("uniqueid");
            urlElement.SetAttribute("type", "MovieScraper-Url");
            urlElement.InnerText = string.Format("{0}", "https://movie.douban.com/subject/35288767/");
            movieElement.AppendChild(urlElement);

            //<moviescraper-urlid>https://movie.douban.com/subject/35288767/</moviescraper-urlid>
            var urlidElement = xmlDocument.CreateElement("moviescraper-urlid");
            urlidElement.InnerText = string.Format("{0}", "https://movie.douban.com/subject/35288767/");
            movieElement.AppendChild(urlidElement);

            #region fileinfo

            var fileinfoElement = xmlDocument.CreateElement("fileinfo");

            var streamdetailsElement = xmlDocument.CreateElement("streamdetails");

            var videoElement = xmlDocument.CreateElement("video");
            var videoInfo = "video";
            if (!string.IsNullOrEmpty(videoInfo))
            {
                //<codec>h264</codec>
                var codecElement = xmlDocument.CreateElement("codec");
                codecElement.InnerText = string.Format("{0}", "h264");
                videoElement.AppendChild(codecElement);

                //<micodec>h264</micodec>
                var micodecElement = xmlDocument.CreateElement("micodec");
                micodecElement.InnerText = string.Format("{0}", "h264");
                videoElement.AppendChild(micodecElement);

                //<bitrate>2909267</bitrate>
                var bitrateElement = xmlDocument.CreateElement("bitrate");
                bitrateElement.InnerText = string.Format("{0}", "2909267");
                videoElement.AppendChild(bitrateElement);

                //<width>1280</width>
                var widthElement = xmlDocument.CreateElement("width");
                widthElement.InnerText = string.Format("{0}", "1280");
                videoElement.AppendChild(widthElement);

                //<height>720</height>
                var heightElement = xmlDocument.CreateElement("height");
                heightElement.InnerText = string.Format("{0}", "720");
                videoElement.AppendChild(heightElement);

                //<aspect>16:9</aspect>
                var aspectElement = xmlDocument.CreateElement("aspect");
                aspectElement.InnerText = string.Format("{0}", "16:9");
                videoElement.AppendChild(aspectElement);

                //<aspectratio>16:9</aspectratio>
                var aspectratioElement = xmlDocument.CreateElement("aspectratio");
                aspectratioElement.InnerText = string.Format("{0}", "16:9");
                videoElement.AppendChild(aspectratioElement);

                //<framerate>29.97003</framerate>
                var framerateElement = xmlDocument.CreateElement("framerate");
                framerateElement.InnerText = string.Format("{0}", "29.97003");
                videoElement.AppendChild(framerateElement);

                //<scantype>progressive</scantype>
                var scantypeElement = xmlDocument.CreateElement("scantype");
                scantypeElement.InnerText = string.Format("{0}", "progressive");
                videoElement.AppendChild(scantypeElement);

                //<default>False</default>
                var defaultElement = xmlDocument.CreateElement("default");
                defaultElement.InnerText = string.Format("{0}", "False");
                videoElement.AppendChild(defaultElement);

                //<forced>False</forced>
                var forcedElement = xmlDocument.CreateElement("forced");
                forcedElement.InnerText = string.Format("{0}", "False");
                videoElement.AppendChild(forcedElement);

                //<duration>33</duration>
                var durationElement = xmlDocument.CreateElement("duration");
                durationElement.InnerText = string.Format("{0}", "33");
                videoElement.AppendChild(durationElement);

                //<durationinseconds>2031</durationinseconds>
                var durationinsecondsElement = xmlDocument.CreateElement("durationinseconds");
                durationinsecondsElement.InnerText = string.Format("{0}", "2031");
                videoElement.AppendChild(durationinsecondsElement);

                streamdetailsElement.AppendChild(videoElement);
            }

            var audioElement = xmlDocument.CreateElement("audio");
            var audioInfo = "audio";
            if (!string.IsNullOrEmpty(audioInfo))
            {
                //<codec>aac</codec>
                var codecElement = xmlDocument.CreateElement("codec");
                codecElement.InnerText = string.Format("{0}", "aac");
                audioElement.AppendChild(codecElement);

                //<micodec>aac</micodec>
                var micodecElement = xmlDocument.CreateElement("micodec");
                micodecElement.InnerText = string.Format("{0}", "aac");
                audioElement.AppendChild(micodecElement);

                //<bitrate>319940</bitrate>
                var bitrateElement = xmlDocument.CreateElement("bitrate");
                bitrateElement.InnerText = string.Format("{0}", "319940");
                audioElement.AppendChild(bitrateElement);

                //<language>eng</language>
                var languageElement = xmlDocument.CreateElement("language");
                languageElement.InnerText = string.Format("{0}", "eng");
                audioElement.AppendChild(languageElement);

                //<scantype>progressive</scantype>
                var scantypeElement = xmlDocument.CreateElement("scantype");
                scantypeElement.InnerText = string.Format("{0}", "progressive");
                audioElement.AppendChild(scantypeElement);

                //<channels>2</channels>
                var channelsElement = xmlDocument.CreateElement("channels");
                channelsElement.InnerText = string.Format("{0}", "2");
                audioElement.AppendChild(channelsElement);

                //<samplingrate>48000</samplingrate>
                var samplingrateElement = xmlDocument.CreateElement("samplingrate");
                samplingrateElement.InnerText = string.Format("{0}", "48000");
                audioElement.AppendChild(samplingrateElement);

                //<default>False</default>
                var defaultElement = xmlDocument.CreateElement("default");
                defaultElement.InnerText = string.Format("{0}", "False");
                audioElement.AppendChild(defaultElement);

                //<forced>False</forced>
                var forcedElement = xmlDocument.CreateElement("forced");
                forcedElement.InnerText = string.Format("{0}", "False");
                audioElement.AppendChild(forcedElement);

                streamdetailsElement.AppendChild(audioElement);
            }
            fileinfoElement.AppendChild(streamdetailsElement);
            movieElement.AppendChild(fileinfoElement);

            #endregion


            xmlDocument.AppendChild(movieElement);

            xmlDocument.Save(AppDomain.CurrentDomain.BaseDirectory + "movie.nfo");

            Console.WriteLine("写入成功！");

            //XmlElement xmlBook;
            //XmlAttribute xmlParticipantType;
            //XmlElement xmlFirstName;
            //XmlElement xmlLastName;

            //XmlDocument xmlDoc = new XmlDocument();
            //XmlElement xmlBooks = xmlDoc.CreateElement("Books");
            //xmlDoc.AppendChild(xmlBooks);

            //xmlBook = xmlDoc.CreateElement("Book");

            //xmlParticipantType = xmlDoc.CreateAttribute("type");
            //xmlParticipantType.InnerText = "Author";
            //xmlBook.Attributes.Append(xmlParticipantType);

            //xmlFirstName = xmlDoc.CreateElement("FirstName");
            //xmlFirstName.InnerText = "J";
            //xmlBook.AppendChild(xmlFirstName);

            //xmlLastName = xmlDoc.CreateElement("LastName");
            //xmlLastName.InnerText = "R";
            //xmlBook.AppendChild(xmlLastName);

            //xmlBooks.AppendChild(xmlBook);

            //xmlBook = xmlDoc.CreateElement("Book");

            //xmlParticipantType = xmlDoc.CreateAttribute("type");
            //xmlParticipantType.InnerText = "Author";
            //xmlBook.Attributes.Append(xmlParticipantType);

            //xmlFirstName = xmlDoc.CreateElement("FirstName");
            //xmlFirstName.InnerText = "E";
            //xmlBook.AppendChild(xmlFirstName);

            //xmlLastName = xmlDoc.CreateElement("LastName");
            //xmlLastName.InnerText = "B";
            //xmlBook.AppendChild(xmlLastName);

            //xmlBooks.AppendChild(xmlBook);

            //XmlNodeList authorsList = xmlDoc.SelectNodes("Books/Book[@type=\"Author\"]");
            //xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "Book.xml");
            //foreach (XmlNode node in authorsList)
            //{
            //    XmlNode firstName = node.SelectSingleNode("FirstName");
            //    XmlNode lastName = node.SelectSingleNode("LastName");
            //    Console.WriteLine("{0} {1}", firstName, lastName);
            //}
        }
    }
}
