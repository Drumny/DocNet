using System;

namespace Src.Common
{
    public class Tools
    {
        /// <summary>
        /// 获取并创建根目录外的兄弟目录
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        public static string GetSiblingFolderPath(string folderName)
        {
            var sibing = "";
            var index = AppContext.BaseDirectory.ToLower().IndexOf(@"\bin\debug\");
            if (index > -1)
            {
                sibing = AppContext.BaseDirectory.Substring(0, index);
            }
            var directoryInfo = System.IO.Directory.GetParent(sibing);
            sibing = System.IO.Path.Combine(directoryInfo.FullName, folderName);

            if (!System.IO.Directory.Exists(sibing))
            {
                System.IO.Directory.CreateDirectory(sibing);
            }
            return sibing;
        }
    }
}
