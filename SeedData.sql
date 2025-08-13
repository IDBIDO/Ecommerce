INSERT INTO
    public."T_Category" (
    "Id",
    "Name",
    "Url",
    "Deleted",
    "Visible"
)
VALUES
    ('38b9307b-f6e2-4953-8a43-0292031058e1', 'Headphones', 'AirPods', false, true),
    ('9c814d4b-e5f3-4e12-87b8-cfc54a1da080', 'Computer', 'MacBooks', false, true),
    ('a0a08e81-9138-4dda-afd1-dea4fb02433b', 'Watch', 'Watchs', false, true),
    ('c2a8fb00-26f3-4b3f-a558-2b22e5ac7614', 'Tablet', 'iPads', false, true),
    ('ea2f54ff-d9cf-471a-ba4e-0fc3f16d89b8', 'Mobile Phone', 'iPhones', false, true);


INSERT INTO public."T_Product"
("Id", "Name", "Description", "ImageUrl", "CategoryId", "Featured", "Deleted", "Visible")
VALUES
    ('4029fb11-c928-44fe-a451-842502e41e0a',
     'MacBook Air',
     '8-core CPU, 10-core GPU, 8GB unified memory, 256GB SSD¹, 16-core Neural Engine, 15.3-inch Liquid Retina display with True Tone³, 1080p FaceTime HD camera, MagSafe 3 charging port, two Thunderbolt / USB 4 ports, Magic Keyboard with Touch ID, Force Touch trackpad, 35W dual USB-C port compact power adapter.',
     'https://www.gizmochina.com/wp-content/uploads/2020/11/MacBook-Air-featured.jpg',
     '9c814d4b-e5f3-4e12-87b8-cfc54a1da080', false, false, true);


INSERT INTO public."T_Product"
("Id", "Name", "Description", "ImageUrl", "CategoryId", "Featured", "Deleted", "Visible")
VALUES
    ('fc7a333a-32f5-4f43-9858-43af1079b605',
     '11-inch iPad Space Gray',
     'M2 chip. M2 is Apple’s next-generation chip with up to 15% faster 8-core CPU, up to 35% faster 10-core GPU¹, 40% faster Neural Engine for quicker machine learning, and 50% more memory bandwidth. M2 brings powerful performance and new features to iPad Pro — enabling realistic 3D designs, complex AR models, and console-quality gaming at high frame rates, all while maintaining excellent all-day battery life².',
     'https://img2.ch999img.com/pic/product/800x800/20190107140039272.jpg',
     'c2a8fb00-26f3-4b3f-a558-2b22e5ac7614', false, false, true);


INSERT INTO public."T_Product"
("Id", "Name", "Description", "ImageUrl", "CategoryId", "Featured", "Deleted", "Visible")
VALUES
    ('b07b851b-45b4-4323-bc33-d2abe640b810',
     'iPhone 14',
     '8-core CPU, 10-core GPU, 8GB unified memory, 256GB SSD¹, 16-core Neural Engine, 15.3-inch Liquid Retina display with True Tone³, 1080p FaceTime HD camera, MagSafe 3 charging port, two Thunderbolt / USB 4 ports, Magic Keyboard with Touch ID, Force Touch trackpad, 35W dual USB-C port compact power adapter.',
     'https://tse3-mm.cn.bing.net/th/id/OIP-C.PyYoIZQs1YVXOO1Oh0b3iwHaHa?pid=ImgDet&rs=1',
     'ea2f54ff-d9cf-471a-ba4e-0fc3f16d89b8', true, false, true);


INSERT INTO public."T_Product"
("Id", "Name", "Description", "ImageUrl", "CategoryId", "Featured", "Deleted", "Visible")
VALUES
    ('ec2a9343-e438-460d-a8df-701cd099e153',
     'Apple Watch Ultra',
     'Apple Watch at the peak of ruggedness and performance. Strong titanium case, precise dual-frequency GPS, up to 36 hours battery life¹, convenient cellular capability², and three specialized bands ready for any challenge.',
     'https://tse4-mm.cn.bing.net/th/id/OIP-C.gdzuQh7D-UOANqSdAd50xQHaHa?pid=ImgDet&rs=1',
     'a0a08e81-9138-4dda-afd1-dea4fb02433b', true, false, true);


INSERT INTO public."T_Product"
("Id", "Name", "Description", "ImageUrl", "CategoryId", "Featured", "Deleted", "Visible")
VALUES
    ('ea91363a-22d5-4030-a429-40ab76be89bf',
     'iPhone 13',
     'Color all around. From RMB 4699. 6.1-inch or 5.4-inch Super Retina XDR display¹, Emergency SOS, Dual-camera system — main camera 12MP + ultra-wide, TrueDepth front camera, up to 19 hours video playback³, A15 Bionic chip with 4-core GPU, Face ID, superfast 5G⁴.',
     'https://m.360buyimg.com/babel/jfs/t1/197206/35/9565/184484/614bdea2E03c07a71/4d07f79f2b372acd.jpg',
     'ea2f54ff-d9cf-471a-ba4e-0fc3f16d89b8', false, false, true);


INSERT INTO public."T_Product"
("Id", "Name", "Description", "ImageUrl", "CategoryId", "Featured", "Deleted", "Visible")
VALUES
    ('299087f6-ff59-41e4-983c-12023c499bef',
     'AirPods (3rd generation)',
     'Music tailored to your ears. Adaptive EQ automatically adjusts sound to your ears. Inward-facing microphones detect what you’re hearing and adjust low and mid frequencies in real time to deliver rich detail in every song.',
     'https://gfs17.gomein.net.cn/T1hwxIBgLT1RCvBVdK_360.jpg',
     '38b9307b-f6e2-4953-8a43-0292031058e1', true, false, true);


INSERT INTO public."T_ProductType" ("Id", "Name")
VALUES
    ('21a06e08-69dc-42fc-b5e3-5e3a267d7561', 'Ultra'),
    ('84ba1752-917e-412e-96d5-8896a206c590', 'Pro Max'),
    ('d9c06b61-0c64-4bb5-a4e7-7642907dbaaa', 'Pro'),
    ('e84893a3-cad7-4ef3-8f7d-58e090c7f128', 'Default');


INSERT INTO public."T_ProductVariant"
("ProductId", "ProductTypeId", "Id", "Price", "OriginalPrice", "Deleted", "Visible")
VALUES
    ('299087f6-ff59-41e4-983c-12023c499bef', 'd9c06b61-0c64-4bb5-a4e7-7642907dbaaa', 'ed664522-8efe-435a-88c7-268eb7d1ede2', 1299.98, 1499.99, false, true),
    ('299087f6-ff59-41e4-983c-12023c499bef', 'e84893a3-cad7-4ef3-8f7d-58e090c7f128', '0af7bff8-57dc-47ea-b2d7-f6d459e18507', 999.89, 1299.65, false, true),
    ('4029fb11-c928-44fe-a451-842502e41e0a', 'd9c06b61-0c64-4bb5-a4e7-7642907dbaaa', 'a355a369-d899-4041-afff-d487d08d910f', 19999.99, 23999.89, false, true),
    ('4029fb11-c928-44fe-a451-842502e41e0a', 'e84893a3-cad7-4ef3-8f7d-58e090c7f128', 'b517ce32-1482-4fbb-b20b-71b134c98cab', 12999.99, 16999.99, false, true),
    ('ec2a9343-e438-460d-a8df-701cd099e153', '21a06e08-69dc-42fc-b5e3-5e3a267d7561', 'bc0eeed2-f35c-485e-82eb-3022a3c7ce4f', 1099.98, 1499.99, false, true),
    ('ec2a9343-e438-460d-a8df-701cd099e153', 'e84893a3-cad7-4ef3-8f7d-58e090c7f128', '17a57b7e-d2e9-4f22-8f87-867bbbe73d02', 899.89, 1099.65, false, true),
    ('fc7a333a-32f5-4f43-9858-43af1079b605', 'd9c06b61-0c64-4bb5-a4e7-7642907dbaaa', 'c130c7d4-b6b5-4ca5-b30d-7dad3c3e256e', 6999.99, 8999.89, false, true),
    ('fc7a333a-32f5-4f43-9858-43af1079b605', 'e84893a3-cad7-4ef3-8f7d-58e090c7f128', 'eef01cf9-1409-41b8-a5f0-713c549738e6', 5999.99, 6999.99, false, true),
    ('b07b851b-45b4-4323-bc33-d2abe640b810', '84ba1752-917e-412e-96d5-8896a206c590', 'ea0106a5-3785-4cc2-9156-611637bf4661', 14299.98, 16299.99, false, true),
    ('b07b851b-45b4-4323-bc33-d2abe640b810', 'd9c06b61-0c64-4bb5-a4e7-7642907dbaaa', '69bfe3d1-1e8a-41dd-ae47-ef9cc645b2a2', 12399.98, 14399.99, false, true),
    ('b07b851b-45b4-4323-bc33-d2abe640b810', 'e84893a3-cad7-4ef3-8f7d-58e090c7f128', '1f2dd3ef-400e-45e8-bb4f-941149ccc63d', 6999.89, 81299.65, false, true),
    ('ea91363a-22d5-4030-a429-40ab76be89bf', '84ba1752-917e-412e-96d5-8896a206c590', '4adbf0f8-3b3e-478d-8c10-c6a501348b09', 8299.98, 12499.99, false, true),
    ('ea91363a-22d5-4030-a429-40ab76be89bf', 'd9c06b61-0c64-4bb5-a4e7-7642907dbaaa', '7c0ec2c5-5667-485c-9482-fa600b7931d4', 6299.98, 9499.99, false, true),
    ('ea91363a-22d5-4030-a429-40ab76be89bf', 'e84893a3-cad7-4ef3-8f7d-58e090c7f128', '633a3aa6-0fdb-4d63-8a08-84d701303c27', 4999.89, 6299.65, false, true);
