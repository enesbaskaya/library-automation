--
-- PostgreSQL database dump
--

-- Dumped from database version 11.5
-- Dumped by pg_dump version 12rc1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: bakiyeAzaltFonk(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."bakiyeAzaltFonk"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
      UPDATE uyeler SET bakiye = bakiye - kitap.bakiye WHERE (kitap . "kitapID" = NEW."kitapNO" AND uyeler . "uyeID" = NEW . "uyeNO") ;
      RETURN NEW;
END
$$;


ALTER FUNCTION public."bakiyeAzaltFonk"() OWNER TO postgres;

--
-- Name: iadeEtmeFonksiyonu(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."iadeEtmeFonksiyonu"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
      INSERT INTO iadeler ("uyeNO","iadeTarihi", "kitapNO") VALUES (OLD ."uyeNO", OLD. "iadeTarihi", OLD."kitapNO");
      RETURN OLD;
END
$$;


ALTER FUNCTION public."iadeEtmeFonksiyonu"() OWNER TO postgres;

--
-- Name: iadeFonks(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."iadeFonks"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
      UPDATE kitap SET adet = adet+1 WHERE "kitapID" = NEW."kitapNO" ;
      RETURN NEW;
END
$$;


ALTER FUNCTION public."iadeFonks"() OWNER TO postgres;

--
-- Name: kiralamaFonks(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."kiralamaFonks"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
      UPDATE kitap SET adet = adet-1 WHERE "kitapID" = NEW."kitapNO" ;
      RETURN NEW;
END
$$;


ALTER FUNCTION public."kiralamaFonks"() OWNER TO postgres;

--
-- Name: satinAlmaFonks(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."satinAlmaFonks"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
      UPDATE kitap SET adet = adet-1 WHERE "kitapID" = NEW."kitapNO" ;
      RETURN NEW;
END
$$;


ALTER FUNCTION public."satinAlmaFonks"() OWNER TO postgres;

--
-- Name: urunDegisikligiTR1(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."urunDegisikligiTR1"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
      INSERT INTO iadeler ("uyeNO","iadeTarihi", "kitapNO") VALUES (OLD ."uyeNO", OLD. "iadeTarihi", OLD."kitapNO");
      RETURN NEW, OLD;
END
$$;


ALTER FUNCTION public."urunDegisikligiTR1"() OWNER TO postgres;

SET default_tablespace = '';

--
-- Name: bolumler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bolumler (
    "bolumID" bigint NOT NULL,
    "bolumAdi" character varying(2044) NOT NULL
);


ALTER TABLE public.bolumler OWNER TO postgres;

--
-- Name: bolumler_bolumID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."bolumler_bolumID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."bolumler_bolumID_seq" OWNER TO postgres;

--
-- Name: bolumler_bolumID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."bolumler_bolumID_seq" OWNED BY public.bolumler."bolumID";


--
-- Name: dil; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dil (
    "dilID" bigint NOT NULL,
    "dilAdi" character varying(2044) NOT NULL
);


ALTER TABLE public.dil OWNER TO postgres;

--
-- Name: dil_dilID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."dil_dilID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."dil_dilID_seq" OWNER TO postgres;

--
-- Name: dil_dilID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."dil_dilID_seq" OWNED BY public.dil."dilID";


--
-- Name: iadeler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.iadeler (
    "iadeID" bigint NOT NULL,
    "kitapNO" bigint NOT NULL,
    "uyeNO" bigint NOT NULL,
    "iadeTarihi" date NOT NULL
);


ALTER TABLE public.iadeler OWNER TO postgres;

--
-- Name: iadeler_iadeID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."iadeler_iadeID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."iadeler_iadeID_seq" OWNER TO postgres;

--
-- Name: iadeler_iadeID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."iadeler_iadeID_seq" OWNED BY public.iadeler."iadeID";


--
-- Name: kategori; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kategori (
    "kategoriID" bigint NOT NULL,
    "kategoriAdi" character varying(2044) NOT NULL
);


ALTER TABLE public.kategori OWNER TO postgres;

--
-- Name: kategori_kategoriID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."kategori_kategoriID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."kategori_kategoriID_seq" OWNER TO postgres;

--
-- Name: kategori_kategoriID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."kategori_kategoriID_seq" OWNED BY public.kategori."kategoriID";


--
-- Name: kiralamalar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kiralamalar (
    "kiralamaID" bigint NOT NULL,
    "kitapNO" bigint NOT NULL,
    "uyeNO" bigint NOT NULL,
    "alisTarihi" date NOT NULL,
    "iadeTarihi" date NOT NULL
);


ALTER TABLE public.kiralamalar OWNER TO postgres;

--
-- Name: kiralamalar_kiralamaID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."kiralamalar_kiralamaID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."kiralamalar_kiralamaID_seq" OWNER TO postgres;

--
-- Name: kiralamalar_kiralamaID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."kiralamalar_kiralamaID_seq" OWNED BY public.kiralamalar."kiralamaID";


--
-- Name: kitap; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kitap (
    "kitapID" bigint NOT NULL,
    "kategoriNO" bigint NOT NULL,
    "dilNO" bigint NOT NULL,
    "yayinEviNO" bigint NOT NULL,
    "ISBN" character varying(2044) NOT NULL,
    adet bigint NOT NULL,
    "girisTarihi" date NOT NULL,
    "basimYili" date NOT NULL,
    "kitapAdi" character varying(2044) NOT NULL,
    fiyat bigint NOT NULL
);


ALTER TABLE public.kitap OWNER TO postgres;

--
-- Name: kitapYazar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."kitapYazar" (
    "kitapNO" bigint NOT NULL,
    "yazarNO" bigint NOT NULL
);


ALTER TABLE public."kitapYazar" OWNER TO postgres;

--
-- Name: kitap_kitapID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."kitap_kitapID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."kitap_kitapID_seq" OWNER TO postgres;

--
-- Name: kitap_kitapID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."kitap_kitapID_seq" OWNED BY public.kitap."kitapID";


--
-- Name: satinAlmalar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."satinAlmalar" (
    "satinAlmaID" bigint NOT NULL,
    "kitapNO" bigint NOT NULL,
    "uyeNO" bigint NOT NULL,
    "alisTarihi" date NOT NULL
);


ALTER TABLE public."satinAlmalar" OWNER TO postgres;

--
-- Name: satinAlmalar_satinAlmaID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."satinAlmalar_satinAlmaID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."satinAlmalar_satinAlmaID_seq" OWNER TO postgres;

--
-- Name: satinAlmalar_satinAlmaID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."satinAlmalar_satinAlmaID_seq" OWNED BY public."satinAlmalar"."satinAlmaID";


--
-- Name: unvanlar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.unvanlar (
    "unvanID" bigint NOT NULL,
    "unvanAdi" character varying(2044) NOT NULL
);


ALTER TABLE public.unvanlar OWNER TO postgres;

--
-- Name: unvanlar_unvanID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."unvanlar_unvanID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."unvanlar_unvanID_seq" OWNER TO postgres;

--
-- Name: unvanlar_unvanID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."unvanlar_unvanID_seq" OWNED BY public.unvanlar."unvanID";


--
-- Name: uye_kart; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.uye_kart (
    "kartID" bigint NOT NULL,
    kart_no smallint NOT NULL,
    cvv smallint NOT NULL,
    skt smallint NOT NULL,
    adsoyad character varying(2044) NOT NULL,
    "uyeNO" bigint NOT NULL
);


ALTER TABLE public.uye_kart OWNER TO postgres;

--
-- Name: uye_kart_kartID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."uye_kart_kartID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."uye_kart_kartID_seq" OWNER TO postgres;

--
-- Name: uye_kart_kartID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."uye_kart_kartID_seq" OWNED BY public.uye_kart."kartID";


--
-- Name: uyeler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.uyeler (
    "uyeID" bigint NOT NULL,
    "adSoyad" character varying(2044) NOT NULL,
    adres character varying(2044) NOT NULL,
    "eMail" character varying(2044) NOT NULL,
    "GSM" character varying(2044) NOT NULL,
    "unvanNo" bigint NOT NULL,
    "bolumNo" bigint NOT NULL,
    yetki boolean DEFAULT false NOT NULL,
    sifre character varying(2044),
    bakiye bigint
);


ALTER TABLE public.uyeler OWNER TO postgres;

--
-- Name: uyeler_uyeID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."uyeler_uyeID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."uyeler_uyeID_seq" OWNER TO postgres;

--
-- Name: uyeler_uyeID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."uyeler_uyeID_seq" OWNED BY public.uyeler."uyeID";


--
-- Name: yayinEvi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."yayinEvi" (
    "yayinEviID" bigint NOT NULL,
    "yayinEviAdi" character varying(2044) NOT NULL
);


ALTER TABLE public."yayinEvi" OWNER TO postgres;

--
-- Name: yayinEvi_yayinEviID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."yayinEvi_yayinEviID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."yayinEvi_yayinEviID_seq" OWNER TO postgres;

--
-- Name: yayinEvi_yayinEviID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."yayinEvi_yayinEviID_seq" OWNED BY public."yayinEvi"."yayinEviID";


--
-- Name: yazar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.yazar (
    "yazarID" bigint NOT NULL,
    "yazarAdiSoyadi" character varying(2044) NOT NULL
);


ALTER TABLE public.yazar OWNER TO postgres;

--
-- Name: yazar_yazarID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."yazar_yazarID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."yazar_yazarID_seq" OWNER TO postgres;

--
-- Name: yazar_yazarID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."yazar_yazarID_seq" OWNED BY public.yazar."yazarID";


--
-- Name: bolumler bolumID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bolumler ALTER COLUMN "bolumID" SET DEFAULT nextval('public."bolumler_bolumID_seq"'::regclass);


--
-- Name: dil dilID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dil ALTER COLUMN "dilID" SET DEFAULT nextval('public."dil_dilID_seq"'::regclass);


--
-- Name: iadeler iadeID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iadeler ALTER COLUMN "iadeID" SET DEFAULT nextval('public."iadeler_iadeID_seq"'::regclass);


--
-- Name: kategori kategoriID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori ALTER COLUMN "kategoriID" SET DEFAULT nextval('public."kategori_kategoriID_seq"'::regclass);


--
-- Name: kiralamalar kiralamaID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kiralamalar ALTER COLUMN "kiralamaID" SET DEFAULT nextval('public."kiralamalar_kiralamaID_seq"'::regclass);


--
-- Name: kitap kitapID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kitap ALTER COLUMN "kitapID" SET DEFAULT nextval('public."kitap_kitapID_seq"'::regclass);


--
-- Name: satinAlmalar satinAlmaID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."satinAlmalar" ALTER COLUMN "satinAlmaID" SET DEFAULT nextval('public."satinAlmalar_satinAlmaID_seq"'::regclass);


--
-- Name: unvanlar unvanID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.unvanlar ALTER COLUMN "unvanID" SET DEFAULT nextval('public."unvanlar_unvanID_seq"'::regclass);


--
-- Name: uye_kart kartID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uye_kart ALTER COLUMN "kartID" SET DEFAULT nextval('public."uye_kart_kartID_seq"'::regclass);


--
-- Name: uyeler uyeID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler ALTER COLUMN "uyeID" SET DEFAULT nextval('public."uyeler_uyeID_seq"'::regclass);


--
-- Name: yayinEvi yayinEviID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."yayinEvi" ALTER COLUMN "yayinEviID" SET DEFAULT nextval('public."yayinEvi_yayinEviID_seq"'::regclass);


--
-- Name: yazar yazarID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.yazar ALTER COLUMN "yazarID" SET DEFAULT nextval('public."yazar_yazarID_seq"'::regclass);


--
-- Data for Name: bolumler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.bolumler VALUES (1, 'Bilgisayar Mühendisliği');
INSERT INTO public.bolumler VALUES (2, 'İşletme');
INSERT INTO public.bolumler VALUES (3, 'Rekrasyon');
INSERT INTO public.bolumler VALUES (4, 'Fizik ');
INSERT INTO public.bolumler VALUES (5, 'Matematik');
INSERT INTO public.bolumler VALUES (6, 'Biyoloji');
INSERT INTO public.bolumler VALUES (7, 'Endüstri Mühendisliği');
INSERT INTO public.bolumler VALUES (8, 'Felsefe');
INSERT INTO public.bolumler VALUES (9, 'Akaid ve Kelam');
INSERT INTO public.bolumler VALUES (10, 'Hukuk');
INSERT INTO public.bolumler VALUES (11, 'Tıp');


--
-- Data for Name: dil; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.dil VALUES (1, 'Türkçe');
INSERT INTO public.dil VALUES (2, 'İngilizce');
INSERT INTO public.dil VALUES (3, 'Almanca');
INSERT INTO public.dil VALUES (4, 'Arapça');
INSERT INTO public.dil VALUES (5, 'Fransızca');
INSERT INTO public.dil VALUES (7, 'Farça');
INSERT INTO public.dil VALUES (8, 'Latince');
INSERT INTO public.dil VALUES (9, 'İbranice');
INSERT INTO public.dil VALUES (10, 'Osmanlıca');
INSERT INTO public.dil VALUES (11, 'Urartuca');
INSERT INTO public.dil VALUES (12, 'Labadanca');
INSERT INTO public.dil VALUES (13, 'Saykoca');
INSERT INTO public.dil VALUES (14, 'İspanyolca');
INSERT INTO public.dil VALUES (15, 'Portekizce');


--
-- Data for Name: iadeler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.iadeler VALUES (1028, 2, 5, '2020-01-11');
INSERT INTO public.iadeler VALUES (1029, 28, 5, '2020-01-11');
INSERT INTO public.iadeler VALUES (1030, 2, 5, '2020-01-12');
INSERT INTO public.iadeler VALUES (1031, 8, 5, '2020-01-11');
INSERT INTO public.iadeler VALUES (1032, 2, 5, '2020-01-12');
INSERT INTO public.iadeler VALUES (1026, 4, 5, '2020-01-11');
INSERT INTO public.iadeler VALUES (1027, 6, 5, '2020-01-11');


--
-- Data for Name: kategori; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kategori VALUES (1, 'Roman');
INSERT INTO public.kategori VALUES (2, 'Bilim Kurgu');
INSERT INTO public.kategori VALUES (3, 'Kişisel Gelişim');
INSERT INTO public.kategori VALUES (4, 'Aksiyon');
INSERT INTO public.kategori VALUES (5, 'Polisiye');
INSERT INTO public.kategori VALUES (6, 'Hikaye');
INSERT INTO public.kategori VALUES (7, 'Ansiklopedi');
INSERT INTO public.kategori VALUES (9, 'Eleştri');
INSERT INTO public.kategori VALUES (10, 'Gazete');
INSERT INTO public.kategori VALUES (11, 'Dergi');
INSERT INTO public.kategori VALUES (12, 'Masal');
INSERT INTO public.kategori VALUES (13, 'Tarihi Roman');
INSERT INTO public.kategori VALUES (14, 'Dini');
INSERT INTO public.kategori VALUES (15, 'Savaş');
INSERT INTO public.kategori VALUES (16, 'Yemek');


--
-- Data for Name: kiralamalar; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: kitap; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kitap VALUES (17, 4, 3, 3, '5665465465', 6, '2019-12-11', '2005-11-11', 'Aşkı Nanun', 6);
INSERT INTO public.kitap VALUES (29, 4, 3, 3, 'a546546', 45, '2019-12-13', '2001-11-11', 'asd', 45);
INSERT INTO public.kitap VALUES (28, 4, 3, 3, '564564564', 15, '2019-12-12', '2003-10-15', 'Cam Bardak', 150);
INSERT INTO public.kitap VALUES (8, 1, 1, 2, '@ISBN', 47, '1998-11-11', '1975-09-10', 's', 50);
INSERT INTO public.kitap VALUES (2, 2, 3, 2, '156514456645523453', 0, '2005-05-05', '1998-02-01', 'Suç ve Ceza', 15);
INSERT INTO public.kitap VALUES (3, 3, 2, 5, '546454566456546513123', 744, '2012-12-12', '2018-09-10', 'Tatile', 1500);
INSERT INTO public.kitap VALUES (11, 4, 3, 3, 'as546as556', 52, '2019-12-10', '2005-11-11', 'asdasd', 15);
INSERT INTO public.kitap VALUES (15, 4, 3, 3, '51456465456', 9, '2019-12-10', '2002-12-25', 'Enes Kitabı', 75);
INSERT INTO public.kitap VALUES (12, 4, 3, 3, '156a4s564s6a54564', 12, '2019-12-10', '2003-12-15', 'Esaret', 8);
INSERT INTO public.kitap VALUES (13, 4, 1, 5, '56456465465456231123312312', 8, '2019-12-10', '2003-02-05', 'Ahmetin Köpekleri', 85);
INSERT INTO public.kitap VALUES (16, 16, 9, 8, '551651654564546', 11, '2019-12-11', '2001-11-15', 'Aslan Parçası', 4);
INSERT INTO public.kitap VALUES (4, 4, 4, 3, '5468978912213312566546', 499, '1996-09-12', '1995-09-12', 'Sıtkı Koçman ', 5);
INSERT INTO public.kitap VALUES (7, 6, 5, 7, '4564654654564', 298, '2006-05-15', '2002-05-14', 'Iguana Ile Delirmeceler', 32);
INSERT INTO public.kitap VALUES (6, 7, 2, 6, '456328489564564698465', 196, '1993-10-11', '1990-04-05', 'The Firs Company', 100);


--
-- Data for Name: kitapYazar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."kitapYazar" VALUES (2, 10);
INSERT INTO public."kitapYazar" VALUES (3, 4);
INSERT INTO public."kitapYazar" VALUES (4, 6);
INSERT INTO public."kitapYazar" VALUES (6, 2);
INSERT INTO public."kitapYazar" VALUES (7, 8);
INSERT INTO public."kitapYazar" VALUES (8, 6);
INSERT INTO public."kitapYazar" VALUES (17, 5);
INSERT INTO public."kitapYazar" VALUES (28, 1);
INSERT INTO public."kitapYazar" VALUES (29, 1);


--
-- Data for Name: satinAlmalar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."satinAlmalar" VALUES (21, 3, 5, '2019-12-13');
INSERT INTO public."satinAlmalar" VALUES (22, 8, 5, '2019-12-13');
INSERT INTO public."satinAlmalar" VALUES (23, 3, 5, '2019-12-13');
INSERT INTO public."satinAlmalar" VALUES (24, 3, 5, '2019-12-13');
INSERT INTO public."satinAlmalar" VALUES (25, 3, 5, '2019-12-13');
INSERT INTO public."satinAlmalar" VALUES (26, 3, 5, '2019-12-13');


--
-- Data for Name: unvanlar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.unvanlar VALUES (1, 'Öğrenci');
INSERT INTO public.unvanlar VALUES (2, 'Profesör');
INSERT INTO public.unvanlar VALUES (3, 'Doçent');
INSERT INTO public.unvanlar VALUES (4, 'Öğretim Üyesi');
INSERT INTO public.unvanlar VALUES (5, 'Araştırma Görevlisi');
INSERT INTO public.unvanlar VALUES (6, 'Personel');


--
-- Data for Name: uye_kart; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.uye_kart VALUES (1, 12345, 0, 1125, 'murat altuğ', 5);


--
-- Data for Name: uyeler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.uyeler VALUES (5, 'Murat Altuğ', 'Bingöl', 'murat@hotmail.com', '00000000001', 5, 3, false, '567', 242760);
INSERT INTO public.uyeler VALUES (1, 'Yusuf Serhat Özgen', 'Serdivan', 'serhat@gmail.com', '05342048114', 1, 1, true, '123', 100);
INSERT INTO public.uyeler VALUES (2, 'Enes Başkaya', 'İstanbul', 'enes@outlook.com', '05345862413', 2, 1, true, '234', 250);
INSERT INTO public.uyeler VALUES (4, 'Yuşa Salda', 'Konya', 'yusa@yandex.com', '05698743211', 1, 1, false, '456', 0);
INSERT INTO public.uyeler VALUES (6, 'Veysel Harun Çakar', 'Bitlis', 'veysel@mynet.com', '04563217895', 1, 1, false, '678', 1500);
INSERT INTO public.uyeler VALUES (15, 'Ahmet', 'Ankara', 'Kol@gom.com', '1561564465465', 1, 1, false, '123456', 50);
INSERT INTO public.uyeler VALUES (17, 'Kemalettin', 'Ankara', 'okullu@gmil.com', '05845632514', 1, 10, false, '123456789', 0);
INSERT INTO public.uyeler VALUES (3, 'Celal Çeken', 'Sakarya', 'celal@yahoo.com', '05345214789', 2, 2, false, '345', 1);


--
-- Data for Name: yayinEvi; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."yayinEvi" VALUES (3, 'Benim Hocam');
INSERT INTO public."yayinEvi" VALUES (2, 'Elma');
INSERT INTO public."yayinEvi" VALUES (1, 'İletişim ');
INSERT INTO public."yayinEvi" VALUES (4, 'Tudem');
INSERT INTO public."yayinEvi" VALUES (5, 'Pearson');
INSERT INTO public."yayinEvi" VALUES (6, 'İnkılap');
INSERT INTO public."yayinEvi" VALUES (7, 'Sel');
INSERT INTO public."yayinEvi" VALUES (8, 'Nobel');
INSERT INTO public."yayinEvi" VALUES (10, 'Yoksunlar');


--
-- Data for Name: yazar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.yazar VALUES (1, 'Orhan Kemal');
INSERT INTO public.yazar VALUES (2, 'Aziz Nesin');
INSERT INTO public.yazar VALUES (3, 'Atilla İlhan');
INSERT INTO public.yazar VALUES (4, 'J.J. Rossesau');
INSERT INTO public.yazar VALUES (5, 'Sabahattin Ali');
INSERT INTO public.yazar VALUES (6, 'Orhan Veli Kanık');
INSERT INTO public.yazar VALUES (7, 'Ahmet Hamdi Tanpınar');
INSERT INTO public.yazar VALUES (8, 'Ahmet Haşim');
INSERT INTO public.yazar VALUES (9, 'Namık Kemal');
INSERT INTO public.yazar VALUES (10, 'J.K. Rowling');
INSERT INTO public.yazar VALUES (11, 'Fyodor Dostoyevski');
INSERT INTO public.yazar VALUES (12, 'Victor Hugo');


--
-- Name: bolumler_bolumID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."bolumler_bolumID_seq"', 14, true);


--
-- Name: dil_dilID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."dil_dilID_seq"', 16, true);


--
-- Name: iadeler_iadeID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."iadeler_iadeID_seq"', 1032, true);


--
-- Name: kategori_kategoriID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."kategori_kategoriID_seq"', 16, true);


--
-- Name: kiralamalar_kiralamaID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."kiralamalar_kiralamaID_seq"', 19, true);


--
-- Name: kitap_kitapID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."kitap_kitapID_seq"', 29, true);


--
-- Name: satinAlmalar_satinAlmaID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."satinAlmalar_satinAlmaID_seq"', 26, true);


--
-- Name: unvanlar_unvanID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."unvanlar_unvanID_seq"', 12, true);


--
-- Name: uye_kart_kartID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."uye_kart_kartID_seq"', 1, true);


--
-- Name: uyeler_uyeID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."uyeler_uyeID_seq"', 17, true);


--
-- Name: yayinEvi_yayinEviID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."yayinEvi_yayinEviID_seq"', 10, true);


--
-- Name: yazar_yazarID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."yazar_yazarID_seq"', 17, true);


--
-- Name: bolumler bolumler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bolumler
    ADD CONSTRAINT bolumler_pkey PRIMARY KEY ("bolumID");


--
-- Name: dil dil_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dil
    ADD CONSTRAINT dil_pkey PRIMARY KEY ("dilID");


--
-- Name: iadeler iadeler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iadeler
    ADD CONSTRAINT iadeler_pkey PRIMARY KEY ("iadeID");


--
-- Name: kategori kategori_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY ("kategoriID");


--
-- Name: kiralamalar kiralamalar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kiralamalar
    ADD CONSTRAINT kiralamalar_pkey PRIMARY KEY ("kiralamaID");


--
-- Name: kitapYazar kitapYazar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."kitapYazar"
    ADD CONSTRAINT "kitapYazar_pkey" PRIMARY KEY ("kitapNO", "yazarNO");


--
-- Name: kitap kitap_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kitap
    ADD CONSTRAINT kitap_pkey PRIMARY KEY ("kitapID");


--
-- Name: satinAlmalar satinAlmalar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."satinAlmalar"
    ADD CONSTRAINT "satinAlmalar_pkey" PRIMARY KEY ("satinAlmaID");


--
-- Name: kitap unique_kitap_ISBN; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kitap
    ADD CONSTRAINT "unique_kitap_ISBN" UNIQUE ("ISBN");


--
-- Name: uyeler unique_uyeler_GSM; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler
    ADD CONSTRAINT "unique_uyeler_GSM" UNIQUE ("GSM");


--
-- Name: uyeler unique_uyeler_eMail; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler
    ADD CONSTRAINT "unique_uyeler_eMail" UNIQUE ("eMail");


--
-- Name: unvanlar unvanlar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.unvanlar
    ADD CONSTRAINT unvanlar_pkey PRIMARY KEY ("unvanID");


--
-- Name: uye_kart uye_kart_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uye_kart
    ADD CONSTRAINT uye_kart_pkey PRIMARY KEY ("kartID");


--
-- Name: uyeler uyeler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler
    ADD CONSTRAINT uyeler_pkey PRIMARY KEY ("uyeID");


--
-- Name: yayinEvi yayinEvi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."yayinEvi"
    ADD CONSTRAINT "yayinEvi_pkey" PRIMARY KEY ("yayinEviID");


--
-- Name: yazar yazar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.yazar
    ADD CONSTRAINT yazar_pkey PRIMARY KEY ("yazarID");


--
-- Name: kiralamalar iadeEdildiginde; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "iadeEdildiginde" BEFORE DELETE ON public.kiralamalar FOR EACH ROW EXECUTE PROCEDURE public."iadeEtmeFonksiyonu"();


--
-- Name: iadeler iadeTrg; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "iadeTrg" AFTER INSERT ON public.iadeler FOR EACH ROW EXECUTE PROCEDURE public."iadeFonks"();


--
-- Name: kiralamalar kiralamaTrg; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "kiralamaTrg" AFTER INSERT ON public.kiralamalar FOR EACH ROW EXECUTE PROCEDURE public."kiralamaFonks"();


--
-- Name: satinAlmalar satinAlmaTrg; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "satinAlmaTrg" AFTER INSERT ON public."satinAlmalar" FOR EACH ROW EXECUTE PROCEDURE public."satinAlmaFonks"();


--
-- Name: uyeler lnk_bolumler_uyeler; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler
    ADD CONSTRAINT lnk_bolumler_uyeler FOREIGN KEY ("bolumNo") REFERENCES public.bolumler("bolumID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kitap lnk_dil_kitap; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kitap
    ADD CONSTRAINT lnk_dil_kitap FOREIGN KEY ("dilNO") REFERENCES public.dil("dilID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kitap lnk_kategori_kitap; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kitap
    ADD CONSTRAINT lnk_kategori_kitap FOREIGN KEY ("kategoriNO") REFERENCES public.kategori("kategoriID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: iadeler lnk_kitap_iadeler; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iadeler
    ADD CONSTRAINT lnk_kitap_iadeler FOREIGN KEY ("kitapNO") REFERENCES public.kitap("kitapID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kiralamalar lnk_kitap_kiralamalar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kiralamalar
    ADD CONSTRAINT lnk_kitap_kiralamalar FOREIGN KEY ("kitapNO") REFERENCES public.kitap("kitapID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kitapYazar lnk_kitap_kitapYazar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."kitapYazar"
    ADD CONSTRAINT "lnk_kitap_kitapYazar" FOREIGN KEY ("kitapNO") REFERENCES public.kitap("kitapID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: satinAlmalar lnk_kitap_satinAlmalar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."satinAlmalar"
    ADD CONSTRAINT "lnk_kitap_satinAlmalar" FOREIGN KEY ("kitapNO") REFERENCES public.kitap("kitapID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: uyeler lnk_unvanlar_uyeler; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler
    ADD CONSTRAINT lnk_unvanlar_uyeler FOREIGN KEY ("unvanNo") REFERENCES public.unvanlar("unvanID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: iadeler lnk_uyeler_iadeler; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.iadeler
    ADD CONSTRAINT lnk_uyeler_iadeler FOREIGN KEY ("uyeNO") REFERENCES public.uyeler("uyeID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kiralamalar lnk_uyeler_kiralamalar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kiralamalar
    ADD CONSTRAINT lnk_uyeler_kiralamalar FOREIGN KEY ("uyeNO") REFERENCES public.uyeler("uyeID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: satinAlmalar lnk_uyeler_satinAlmalar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."satinAlmalar"
    ADD CONSTRAINT "lnk_uyeler_satinAlmalar" FOREIGN KEY ("uyeNO") REFERENCES public.uyeler("uyeID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: uye_kart lnk_uyeler_uye_kart; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uye_kart
    ADD CONSTRAINT lnk_uyeler_uye_kart FOREIGN KEY ("uyeNO") REFERENCES public.uyeler("uyeID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kitap lnk_yayinEvi_kitap; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kitap
    ADD CONSTRAINT "lnk_yayinEvi_kitap" FOREIGN KEY ("yayinEviNO") REFERENCES public."yayinEvi"("yayinEviID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kitapYazar lnk_yazar_kitapYazar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."kitapYazar"
    ADD CONSTRAINT "lnk_yazar_kitapYazar" FOREIGN KEY ("yazarNO") REFERENCES public.yazar("yazarID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

