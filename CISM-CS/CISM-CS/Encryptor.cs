using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;

namespace CISM_CS
{
    class Encryptor
    {
        private static string GenerateKey()
        {
            int number,number2;
            char code;
            string checkCode = String.Empty;
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                number = random.Next();
                number2 = random.Next();

                if (number % 2 == 0 && number2 % 2 == 0) {
                    code = (char)('0' + (char)(number % 10));
                }
                else if (number % 2 == 0 || number2 % 2 == 0){
                    code = (char)('A' + (char)(number % 26));
                }    
                else code = (char)('a' + (char)(number % 26));
                checkCode += code.ToString();
            }
            return checkCode;
        }
        //生成随机密钥字符串
        private static string encryptKey = GenerateKey();    //生成并赋值密钥 
        public void ResetKey()
        {
            encryptKey = GenerateKey();
        }                           
        //重置密钥值  
        public string Encrypt(string str)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();   //实例化加解密类对象   
            byte[] key = Encoding.Unicode.GetBytes(encryptKey); //定义字节数组，用来存储密钥    
            byte[] data = Encoding.Unicode.GetBytes(str);//定义字节数组，用来存储要加密的字符串  
            MemoryStream MStream = new MemoryStream(); //实例化内存流对象      
            //使用内存流实例化加密流对象   
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);  //向加密流中写入数据      
            CStream.FlushFinalBlock();              //释放加密流      
            return Convert.ToBase64String(MStream.ToArray());//返回string型加密结果  
        }                
        //字符串加密方法
        public string Decrypt(string str)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);    
            byte[] data = Convert.FromBase64String(str);//定义字节数组，用来存储要解密的字符串  
            MemoryStream MStream = new MemoryStream();      
            //使用内存流实例化解密流对象       
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data, 0, data.Length);      //向解密流中写入数据     
            CStream.FlushFinalBlock();               //释放解密流      
            return Encoding.Unicode.GetString(MStream.ToArray());       //返回string型解密结果  
        }                
        //字符串解密方法
    }
}
