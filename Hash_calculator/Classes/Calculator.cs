using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hash_calculator.Classes
{
     class FileSettings
    {
        //IO success
        public readonly bool success;
        //IO error exeption or success message
        public readonly string message;
        //File path
        public readonly string path;
        //File name
        public readonly string name;
        //File size
        public readonly string size;
        //file size in bytes
        public readonly long lenght;
        private string FormatedataSize(long fileSize)
        {
            // IEC sizes array: KByte, MByte, GByte and TByte respectively
            double[] sizes = new double[] { 1024, Math.Pow(1024, 2), Math.Pow(1024, 3), Math.Pow(1024, 4) };
            // Format as size in bytes, if size < 1024^1
            if (fileSize < sizes[0]) return $"{fileSize} B";
            // Format in KB
            if (fileSize < sizes[1]) return $"{fileSize / sizes[0]:F2} KB";
            // Format in MB
            if (fileSize < sizes[2]) return $"{fileSize / sizes[1]:F2} MB";
            // Format in GB
            if (fileSize < sizes[3]) return $"{fileSize / sizes[2]:F2} GB";
            // Format in TB
            return $"{fileSize / sizes[3]:F2} TB";
        }
        public FileSettings(string filepath = "<??nofile??>")
        {
            if (filepath == "<??nofile??>")
                success = false;
            message = "No file choosen";
            try
            {
                FileInfo info = new FileInfo(filepath);
                path = info.FullName;
                name = $"{info.Name}";
                size = FormatedataSize(info.Length);
                lenght = info.Length;
                success = true;
                message = "success";
            }
            catch (Exception err)
            {
                success = false;
                message = err.Message;
            }

        }
    }
    public static class Hash_sum
    {
        private static dynamic getAlgo(string alg = "md5")
        {
            //Filter by shortname
            if (alg == "sha1")
                return SHA1.Create();
            if (alg == "sha256")
                return SHA256.Create();
            if (alg == "sha384")
                return SHA384.Create();
            if (alg == "sha512")
                return SHA512.Create();
            // if nothing matched - return MD% instance
            return MD5.Create();
        }
        public static string[] compute(FileStream str, string alg)
        {
            string[] results = { "hash", "totalSeconds" };
            //time when computing started
            DateTime start = DateTime.Now;
            using (var ALG = getAlgo(alg))
            {
                byte[] hash = ALG.ComputeHash(str);
                results[0] = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
                results[1] = (DateTime.Now - start).TotalSeconds.ToString();
                return results;
            }
        }
    }
}
