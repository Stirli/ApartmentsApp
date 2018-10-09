using System;
using System.Collections.Generic;
using System.Text;
using ApartmentApp.Domain.Interfaces;
using ApartmentApp.Domain.SimpleRepo;

namespace ApartmentApp.Domain
{
   public static class RepoFactory
    {

        private static string[] _pics =
        {
            "https://im0-tub-by.yandex.net/i?id=30c79ccbfa0a9ea0c3aaf307a5a95313&n=13",

            "https://im0-tub-by.yandex.net/i?id=6c3d079928f4c7d37a566f3f270a3661&n=13",

            "https://im0-tub-by.yandex.net/i?id=e32e1ac2b71a00e3d8386a617e26da98&n=13",

            "https://im0-tub-by.yandex.net/i?id=8613c0fb0d98b16431b3afb4bf2c028d&n=13",

            "https://im0-tub-by.yandex.net/i?id=80c15f50bee1b6b3947c7c2b09841fc0&n=13",

            "https://im0-tub-by.yandex.net/i?id=1fbbedfd0121e47fb4d04dcf6fb0cdc0&n=13",

            "https://im0-tub-by.yandex.net/i?id=66b36de6943dbd948881c23863db7c93&n=13",

            "https://im0-tub-by.yandex.net/i?id=c20b1280c64cb39c47e6443bd4cb6591&n=13",

            "https://im0-tub-by.yandex.net/i?id=06b0d62c3349df0d59b33b8c5b0bbbaa&n=13",

            "https://im0-tub-by.yandex.net/i?id=0c200e5dc029df2fb1a2ae7fff6c7a21&n=13",

            "https://im0-tub-by.yandex.net/i?id=4f4824b18ef562f213c9eab63a772a83&n=13",

            "https://im0-tub-by.yandex.net/i?id=11b44828188e2c6a5db4ac7e186597d4&n=13",

            "https://im0-tub-by.yandex.net/i?id=bce2a3cf1d06d559adfde3fe17fd5f2d&n=13",

            "https://im0-tub-by.yandex.net/i?id=8bc95e3510686541c703f937402833fd&n=13",

            "https://im0-tub-by.yandex.net/i?id=1a874abd273ffe5956aa90e69fb0e339&n=13",

            "https://im0-tub-by.yandex.net/i?id=2ce913b4a8dbf343485cd6e1bcc6ed14&n=13",

            "https://im0-tub-by.yandex.net/i?id=b7ee9f1c45c02636dcb726144ed9c76a&n=13",

            "https://im0-tub-by.yandex.net/i?id=12a21bc49c108d334047470acc25b61f&n=13",

            "https://im0-tub-by.yandex.net/i?id=8c947be08b555aa0858e73ab6b511519&n=13",

            "https://im0-tub-by.yandex.net/i?id=0254c5f112e3012189e368ffd660d6cc&n=13",

            "https://im0-tub-by.yandex.net/i?id=257b26eb7dff28e64370221fe88aa162&n=13",

            "https://im0-tub-by.yandex.net/i?id=4f7de6fed7f81caf6aaf4620cb5442eb&n=13",

            "https://im0-tub-by.yandex.net/i?id=6c5797f452c355ccdda028fb1de2d3b9&n=13",

            "https://im0-tub-by.yandex.net/i?id=e41c6836f14950211feed2a4f5b63012&n=11",

            "https://im0-tub-by.yandex.net/i?id=ab1bd1548fe2a3d4950f95792bedf132&n=11",

            "https://im0-tub-by.yandex.net/i?id=2f91817abb3f798d7c85c59f358c60c7&n=11",

            "https://im0-tub-by.yandex.net/i?id=5e4ede28dc7a7a079c394d36858df037&n=11",

            "https://im0-tub-by.yandex.net/i?id=a49d60a2b5d1da74d83cbc61e0002b8d&n=11",

            "https://im0-tub-by.yandex.net/i?id=7620a2ea05c55810142c10a546229307&n=11",

            "https://im0-tub-by.yandex.net/i?id=59160ff321866123b85fe781a4b9d782&n=11",

            "https://im0-tub-by.yandex.net/i?id=13c3c6818d80e8733f6ff168cb48e06b&n=11",

            "https://im0-tub-by.yandex.net/i?id=1da1e5571ceeb0e5fd6e1e741486efd6&n=11",

            "https://im0-tub-by.yandex.net/i?id=788113925d9c686012bc99e6076d8281&n=11",

            "https://im0-tub-by.yandex.net/i?id=784a3c99a247d25ebf9d589be85067bb&n=11",

            "https://im0-tub-by.yandex.net/i?id=36ad61554453cbee9913002f8c2d3572&n=11",

            "https://im0-tub-by.yandex.net/i?id=2ebd528f9d7aa91fe0f1e5367a8f34e0&n=13",

            "https://im0-tub-by.yandex.net/i?id=5e84ca2f829047d3afb632aa59172f67&n=13",

            "https://im0-tub-by.yandex.net/i?id=ba2064784376fde29360b05f7bf7080b&n=13",

            "https://im0-tub-by.yandex.net/i?id=62f25e3c4a13783185fe8ecb5583429d&n=13",

            "https://im0-tub-by.yandex.net/i?id=94840359a0ef5dd073a90de6bf01f943&n=13",

            "https://im0-tub-by.yandex.net/i?id=ee357ec4283f0e4def598e2fad943215&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=71551ca2e17efbfb5803c166ba66cec9&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=6926817b242d312ad302a3284ab2e932&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=616e410de4a8e5f9721c55e73d9c9625&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=1038ed4277201966bfea64de5b0cf1b7&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=8ccfa915e63b09acd494e7daa50f6c96&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=a2fd146a8cd2760ee9c2e3ddeb65bdf0&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=3b70c3f73b0742c36fa01d84dda44efc&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=345c169f87623507741c0e7a6c3c36af&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=2397ef61a80dd748dc1dc0c677d40031&n=13&ref=kokoko",

            "https://im0-tub-by.yandex.net/i?id=b7d39166837da5a81c0c63b8dbe90160&n=13",

            "https://im0-tub-by.yandex.net/i?id=13fbc9685bb182566fac85f26ed973be&n=13",

            "https://im0-tub-by.yandex.net/i?id=025d5f8ee980c1eb5886a04a7ddbd467&n=13",

            "https://im0-tub-by.yandex.net/i?id=288df2f489b1ccbf5e281ded5403f2df&n=13",

            "https://im0-tub-by.yandex.net/i?id=b8f39d9652df4d50068671e8fcc08270&n=13",

            "https://im0-tub-by.yandex.net/i?id=8f42c5de827ed0b3fa546463ff208736&n=13",

            "https://im0-tub-by.yandex.net/i?id=d8fded861be576d5f87c24552abbd146&n=13",

            "https://im0-tub-by.yandex.net/i?id=65098670ee813af36533638a23b9e4d8&n=13",

            "https://im0-tub-by.yandex.net/i?id=4aaf41805fa5b80fe1c6f35cd63294a7&n=13",

            "https://im0-tub-by.yandex.net/i?id=ff46296a65d69b0962e36a3210ee4348&n=13",

            "https://im0-tub-by.yandex.net/i?id=84c50ae4e95bec4c72f1fdf2975c9bfa&n=13",

            "https://im0-tub-by.yandex.net/i?id=d3ad84e64bc2a05d804d742e759c2a40&n=13",

            "https://im0-tub-by.yandex.net/i?id=d86754855812ab83cb38b161fa2f0c99&n=13",

            "https://im0-tub-by.yandex.net/i?id=4c671af88c2843e17beb4161abf886f1&n=13",

            "https://im0-tub-by.yandex.net/i?id=a2f726dee744624ff31eec3836f3b9c5&n=13",

            "https://im0-tub-by.yandex.net/i?id=25b0fe991f222072c155a15f81602cce&n=13",

            "https://im0-tub-by.yandex.net/i?id=2c65623171a119ebe88d4560c070a8ae&n=13",

            "https://im0-tub-by.yandex.net/i?id=9cfd0fa3d321dd29e2c1d3d169cfc955&n=13",

            "https://im0-tub-by.yandex.net/i?id=95fff59aed960ab57b8b2f5bf0a1bf38&n=13",

            "https://im0-tub-by.yandex.net/i?id=9f15c2191d6143c29bfaafd3475be31d&n=13",

            "https://im0-tub-by.yandex.net/i?id=f5d86d86930c4c20c8a0bb8776555d87&n=13",

            "https://im0-tub-by.yandex.net/i?id=0c179e24969685e31b4f3c88fb2e4e88&n=13",

            "https://im0-tub-by.yandex.net/i?id=3f64599754769b0a70cdd9bcfee84563&n=13",

            "https://im0-tub-by.yandex.net/i?id=91f01a11fe651ee4606aca1f4702cb4e&n=13",

            "https://im0-tub-by.yandex.net/i?id=32684f99174d122ed3e03535b3156077&n=13",

            "https://im0-tub-by.yandex.net/i?id=6c828769c45a0afea1a28d0e6776e98e&n=13",

            "https://im0-tub-by.yandex.net/i?id=a0bab6476954d3d634501fc2d4aa7f1a&n=13",

            "https://im0-tub-by.yandex.net/i?id=2e2eab3fd82d75732c5e93c5c57a85d7&n=13",

            "https://im0-tub-by.yandex.net/i?id=2ff283b9b3b8db9714bba03bdfa6870c&n=13",

            "https://im0-tub-by.yandex.net/i?id=45a229969e38a9d680099b7d07316f8f&n=13",

            "https://im0-tub-by.yandex.net/i?id=b9ee8761a7b54b11504761b74a48734b&n=13",

            "https://im0-tub-by.yandex.net/i?id=b45c1862e0ec5f07ace472ae664fc918&n=13",

            "https://im0-tub-by.yandex.net/i?id=815c05f991a155521af4b2a2ccf94283&n=13",

            "https://im0-tub-by.yandex.net/i?id=c917ce50dcc95ea5136a8530583ef32e&n=13",

            "https://im0-tub-by.yandex.net/i?id=90419a2d9f9eeb9dade664411305c548&n=13",

            "https://im0-tub-by.yandex.net/i?id=8fefab3c50343d4140e1c9f57f04cfbb&n=13",

            "https://im0-tub-by.yandex.net/i?id=3b972a60b20b6590651b0819edd5ef79&n=13",

            "https://im0-tub-by.yandex.net/i?id=043d3b4a39a0a4e79c4e7a5258409fca&n=13",

            "https://im0-tub-by.yandex.net/i?id=00afeb4c7963b2924050a89e1eaebcb6&n=13",

            "https://im0-tub-by.yandex.net/i?id=bcf1491d625baf9288c02ad6a40c2fea&n=13",

            "https://im0-tub-by.yandex.net/i?id=ca4aec6342ba164e24bec4024c3d4b57&n=13",

            "https://im0-tub-by.yandex.net/i?id=bd4d55cefef027ce74ad0575a56cd9aa&n=13",

            "https://im0-tub-by.yandex.net/i?id=afafcab3e419eace4cbde361b057d69b&n=13",

            "https://im0-tub-by.yandex.net/i?id=2c2acd917430351318eb64787d36c6e1&n=13",

            "https://im0-tub-by.yandex.net/i?id=726055d792dceb7f91f9f0bb4e6d47c1&n=13",

            "https://im0-tub-by.yandex.net/i?id=eaddb38ca4a382ad490553900828f473&n=13",

            "https://im0-tub-by.yandex.net/i?id=675c4ec1df6335d22ce03341002a9497&n=13",

            "https://im0-tub-by.yandex.net/i?id=c087b1d8f04b6c4989f38d9b333b1ecd&n=13",

            "https://im0-tub-by.yandex.net/i?id=8e39eb5927ad603b249317f0ff7054bf&n=13",

            "https://im0-tub-by.yandex.net/i?id=cf2ffca9c88301364aab3eef59d4eab3&n=13",

            "https://im0-tub-by.yandex.net/i?id=1cf5ce867d4caa65e1a67afff2191157&n=13",

            "https://im0-tub-by.yandex.net/i?id=add6db31fde0142e56da060c0f82da3a&n=13",

            "https://im0-tub-by.yandex.net/i?id=59bdb9ca8799bcf11b17b8481cb0bc04&n=13",

            "https://im0-tub-by.yandex.net/i?id=5ba7bc63a3312e09f3f557ddb4f8db53&n=13",

            "https://im0-tub-by.yandex.net/i?id=2df3fe588da83dbbbcd18721470b9b5c&n=13",

            "https://im0-tub-by.yandex.net/i?id=b2727d809b745602019e35ee31eb8eaa&n=13",

            "https://im0-tub-by.yandex.net/i?id=1cb7d1ceee7364c76e097348b908126f&n=13",

            "https://im0-tub-by.yandex.net/i?id=0ba92cf57bc8fd689696dde6e702c6b3&n=13",

            "https://im0-tub-by.yandex.net/i?id=b0a604bab9638e33c96dcb015ac88e03&n=13",

            "https://im0-tub-by.yandex.net/i?id=99dfd445102c09609f7778fbeb116c08&n=13",

            "https://im0-tub-by.yandex.net/i?id=5ec9c26e6a96454048038caf2e38ed05&n=13",

            "https://im0-tub-by.yandex.net/i?id=840908f80c490eacfb080e4b1a384250&n=13",
        };

        private static IRepository<Apartment> _defaultRepo;
        public static IRepository<Apartment> DefaultRepo => _defaultRepo ?? (_defaultRepo = MakeRandomRepo());

        private static IRepository<Apartment> MakeRandomRepo()
        {
            Random r = new Random();
            string[] streets = { "ул. ", "пер. ", "просп. " };
            List<Apartment> apartments = new List<Apartment>();
            int count = r.Next(3, 200);
            for (int i = 0; i < count; i++)
            {
                apartments.Add(new Apartment()
                {
                    Id = i,
                    Address = $"{streets[r.Next(0, 2)]} Рандом{r.Next(1, 100)}, дом {r.Next(1, 500)}, кв. {r.Next(1, 500)}",
                    Cost = r.Next(100000, 100000000),
                    RoomsCount = r.Next(1, 7),
                    ImgSrc = _pics[r.Next(0, _pics.Length - 1)]
                });
            }
            return new Repository(apartments: apartments);
        }
    }
}
