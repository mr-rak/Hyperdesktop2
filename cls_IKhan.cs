﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using System.Text;

namespace hyperdesktop2
{
    class IKhan
    {
        public static WebClient web_client = new WebClient();

        public static Boolean upload(Bitmap bmp)
        {
            try
            {
                var data = new NameValueCollection();

                var image = Global_Func.bmp_to_base64(bmp, Global_Func.ext_to_imageformat(Settings.upload_format));
                data.Add("image", image);

                web_client.Headers.Add("Authorization", Settings.api_key);
                web_client.UploadValuesAsync(
                    new Uri("http://ikhan.it/imghost/up/"),
                    "POST",
                    data
                );

                web_client.Headers.Remove("Authorization");
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static Boolean delete(String delete_hash)
        {
            try
            {
                var web_client = new WebClient();

                web_client.Headers.Add("Authorization", Settings.api_key);
                web_client.UploadData(
                    new Uri("http://ikhan.it/imghost/del/" + delete_hash),
                    "DELETE",
                    new Byte[] { 0x0 }
                );

                web_client.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
