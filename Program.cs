using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DownloadImage
{
    class Program
    {
        static async Task Main()
        {
            string imageUrl = "https://media.istockphoto.com/id/1144671250/uk/%D1%84%D0%BE%D1%82%D0%BE/%D0%B1%D1%83%D0%B7%D0%BA%D0%BE%D0%B2%D0%B0-%D0%B1%D1%80%D0%B8%D1%82%D0%B0%D0%BD%D1%81%D1%8C%D0%BA%D0%B0-%D0%BA%D1%96%D1%88%D0%BA%D0%B0-%D0%B7-%D0%B1%D0%BB%D0%B0%D0%BA%D0%B8%D1%82%D0%BD%D0%BE%D1%8E-%D1%88%D0%B5%D1%80%D1%81%D1%82%D1%8E-%D0%B4%D0%B8%D0%B2%D0%B8%D1%82%D1%8C%D1%81%D1%8F-%D0%B2%D0%B3%D0%BE%D1%80%D1%83-%D0%BA%D1%96%D1%82-%D0%B2%D1%96%D0%B4%D0%BA%D1%80%D0%B8%D0%B2-%D1%80%D0%BE%D1%82-%D0%B7-%D0%B1%D0%BE%D0%B6%D0%B5%D0%B2%D1%96%D0%BB%D1%8C%D0%BD%D0%B8%D0%BC.jpg?s=1024x1024&w=is&k=20&c=UKvSoMz-eiiESeZbTT579kDBeTZRmlK6aCUfLWwRDik=";

            string localFilePath = @"D:\downloaded_image.jpg";

            using HttpClient client = new HttpClient();

            try
            {
                Console.WriteLine("Загрузка изображения...");
                byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);

                await File.WriteAllBytesAsync(localFilePath, imageBytes);
                Console.WriteLine($"Изображение успешно сохранено по пути: {localFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при скачивании изображения: {ex.Message}");
            }
        }
    }
}

