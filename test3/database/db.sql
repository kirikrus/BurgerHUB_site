--
-- PostgreSQL database dump
--

-- Dumped from database version 15.3
-- Dumped by pg_dump version 15.3

-- Started on 2023-05-22 14:49:23

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
-- TOC entry 2 (class 3079 OID 16384)
-- Name: adminpack; Type: EXTENSION; Schema: -; Owner: -
--

CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;


--
-- TOC entry 3447 (class 0 OID 0)
-- Dependencies: 2
-- Name: EXTENSION adminpack; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 227 (class 1259 OID 16470)
-- Name: burger; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.burger (
    id_burger bigint NOT NULL,
    price numeric NOT NULL,
    photo text NOT NULL,
    cooking_time numeric NOT NULL,
    weight integer NOT NULL,
    hit_or_not integer NOT NULL,
    eco_or_not integer NOT NULL,
    description text NOT NULL,
    name text NOT NULL,
    composition text NOT NULL,
    id_calories_burger bigint NOT NULL
);


ALTER TABLE public.burger OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 16479)
-- Name: burger_constructor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.burger_constructor (
    id_burger_constructor bigint NOT NULL,
    price numeric NOT NULL,
    weight integer NOT NULL,
    name text NOT NULL,
    id_ingredients bigint,
    id_calories_constructor bigint
);


ALTER TABLE public.burger_constructor OWNER TO postgres;

--
-- TOC entry 230 (class 1259 OID 16482)
-- Name: burger_constructor_id_burger_constructor_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.burger_constructor ALTER COLUMN id_burger_constructor ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.burger_constructor_id_burger_constructor_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 228 (class 1259 OID 16473)
-- Name: burger_id_burger_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.burger ALTER COLUMN id_burger ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.burger_id_burger_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 231 (class 1259 OID 16488)
-- Name: calories_burger; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.calories_burger (
    id_calories_burger bigint NOT NULL,
    proteins integer NOT NULL,
    fasts integer NOT NULL,
    carbohydrates integer NOT NULL,
    calories integer NOT NULL
);


ALTER TABLE public.calories_burger OWNER TO postgres;

--
-- TOC entry 232 (class 1259 OID 16491)
-- Name: calories_burger_id_calories_burger_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.calories_burger ALTER COLUMN id_calories_burger ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.calories_burger_id_calories_burger_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 239 (class 1259 OID 16525)
-- Name: calories_constructor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.calories_constructor (
    id_calories_constructor bigint NOT NULL,
    proteins integer NOT NULL,
    fasts integer NOT NULL,
    carbohydrates integer NOT NULL,
    calories integer NOT NULL
);


ALTER TABLE public.calories_constructor OWNER TO postgres;

--
-- TOC entry 240 (class 1259 OID 16528)
-- Name: calories_constructor_id_calories_constructor_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.calories_constructor ALTER COLUMN id_calories_constructor ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.calories_constructor_id_calories_constructor_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 237 (class 1259 OID 16515)
-- Name: calories_ingredients; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.calories_ingredients (
    id_calories_ingredients bigint NOT NULL,
    proteins integer NOT NULL,
    fasts integer NOT NULL,
    carbohydrates integer NOT NULL,
    calories integer NOT NULL
);


ALTER TABLE public.calories_ingredients OWNER TO postgres;

--
-- TOC entry 238 (class 1259 OID 16519)
-- Name: calories_ingredients_id_calories_ingredients_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.calories_ingredients ALTER COLUMN id_calories_ingredients ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.calories_ingredients_id_calories_ingredients_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 221 (class 1259 OID 16449)
-- Name: delivery; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.delivery (
    id_delivery bigint NOT NULL,
    name_delivery text NOT NULL,
    surname text NOT NULL,
    patronymic text NOT NULL,
    phone_number text NOT NULL
);


ALTER TABLE public.delivery OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 16454)
-- Name: delivery_id_delivery_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.delivery ALTER COLUMN id_delivery ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.delivery_id_delivery_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 218 (class 1259 OID 16432)
-- Name: history_of_orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.history_of_orders (
    id_history bigint NOT NULL,
    date_of_order timestamp without time zone NOT NULL,
    address text NOT NULL,
    "time" timestamp without time zone NOT NULL,
    sum_of_order numeric NOT NULL,
    id_positions_of_history bigint NOT NULL
);


ALTER TABLE public.history_of_orders OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16448)
-- Name: history_of_orders_id_history_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.history_of_orders ALTER COLUMN id_history ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.history_of_orders_id_history_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 235 (class 1259 OID 16506)
-- Name: ingredients; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ingredients (
    id_ingredients bigint NOT NULL,
    ingredient text NOT NULL,
    quantity integer NOT NULL,
    price numeric NOT NULL,
    photo_above text NOT NULL,
    photo_side text NOT NULL,
    weight integer NOT NULL,
    id_calories_ingredients bigint NOT NULL
);


ALTER TABLE public.ingredients OWNER TO postgres;

--
-- TOC entry 236 (class 1259 OID 16509)
-- Name: ingredients_id_ingredients_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.ingredients ALTER COLUMN id_ingredients ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.ingredients_id_ingredients_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 215 (class 1259 OID 16421)
-- Name: order; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."order" (
    id_order bigint NOT NULL,
    id_user bigint NOT NULL,
    order_data timestamp without time zone NOT NULL,
    id_delivery bigint NOT NULL,
    id_payment bigint NOT NULL,
    id_positions_order bigint NOT NULL
);


ALTER TABLE public."order" OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16435)
-- Name: order_id_order_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."order" ALTER COLUMN id_order ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.order_id_order_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 223 (class 1259 OID 16455)
-- Name: payment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.payment (
    id_payment bigint NOT NULL,
    number_card text NOT NULL,
    cvv integer NOT NULL,
    validity_period timestamp without time zone[] NOT NULL
);


ALTER TABLE public.payment OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 16460)
-- Name: payment_id_payment_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.payment ALTER COLUMN id_payment ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.payment_id_payment_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 225 (class 1259 OID 16461)
-- Name: positions_of_history; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.positions_of_history (
    id_positions bigint NOT NULL,
    quantity_burger integer NOT NULL,
    quantity_burger_constructor integer NOT NULL,
    id_burger bigint NOT NULL,
    id_burger_constructor bigint NOT NULL
);


ALTER TABLE public.positions_of_history OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 16464)
-- Name: positions_id_positions_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.positions_of_history ALTER COLUMN id_positions ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.positions_id_positions_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 233 (class 1259 OID 16497)
-- Name: positions_order; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.positions_order (
    id_positions_order bigint NOT NULL,
    quantity_burger integer NOT NULL,
    quantity_burger_constructor integer NOT NULL,
    id_burger bigint NOT NULL,
    id_burger_constructor bigint NOT NULL
);


ALTER TABLE public.positions_order OWNER TO postgres;

--
-- TOC entry 234 (class 1259 OID 16500)
-- Name: positions_order_id_positions_order_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.positions_order ALTER COLUMN id_positions_order ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.positions_order_id_positions_order_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 216 (class 1259 OID 16424)
-- Name: user_; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.user_ (
    id_user bigint NOT NULL,
    "user_name " text NOT NULL,
    surname text NOT NULL,
    patronymic text NOT NULL,
    email text NOT NULL,
    password text NOT NULL,
    phone_number text NOT NULL,
    address text NOT NULL,
    burgers text NOT NULL,
    rank text NOT NULL,
    photo text NOT NULL,
    id_history_of_orders bigint NOT NULL
);


ALTER TABLE public.user_ OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16429)
-- Name: user__id_user_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.user_ ALTER COLUMN id_user ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.user__id_user_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 3428 (class 0 OID 16470)
-- Dependencies: 227
-- Data for Name: burger; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3430 (class 0 OID 16479)
-- Dependencies: 229
-- Data for Name: burger_constructor; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3432 (class 0 OID 16488)
-- Dependencies: 231
-- Data for Name: calories_burger; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3440 (class 0 OID 16525)
-- Dependencies: 239
-- Data for Name: calories_constructor; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3438 (class 0 OID 16515)
-- Dependencies: 237
-- Data for Name: calories_ingredients; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3422 (class 0 OID 16449)
-- Dependencies: 221
-- Data for Name: delivery; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3419 (class 0 OID 16432)
-- Dependencies: 218
-- Data for Name: history_of_orders; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3436 (class 0 OID 16506)
-- Dependencies: 235
-- Data for Name: ingredients; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3416 (class 0 OID 16421)
-- Dependencies: 215
-- Data for Name: order; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3424 (class 0 OID 16455)
-- Dependencies: 223
-- Data for Name: payment; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3426 (class 0 OID 16461)
-- Dependencies: 225
-- Data for Name: positions_of_history; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3434 (class 0 OID 16497)
-- Dependencies: 233
-- Data for Name: positions_order; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3417 (class 0 OID 16424)
-- Dependencies: 216
-- Data for Name: user_; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3448 (class 0 OID 0)
-- Dependencies: 230
-- Name: burger_constructor_id_burger_constructor_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.burger_constructor_id_burger_constructor_seq', 1, false);


--
-- TOC entry 3449 (class 0 OID 0)
-- Dependencies: 228
-- Name: burger_id_burger_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.burger_id_burger_seq', 1, false);


--
-- TOC entry 3450 (class 0 OID 0)
-- Dependencies: 232
-- Name: calories_burger_id_calories_burger_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.calories_burger_id_calories_burger_seq', 1, false);


--
-- TOC entry 3451 (class 0 OID 0)
-- Dependencies: 240
-- Name: calories_constructor_id_calories_constructor_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.calories_constructor_id_calories_constructor_seq', 1, false);


--
-- TOC entry 3452 (class 0 OID 0)
-- Dependencies: 238
-- Name: calories_ingredients_id_calories_ingredients_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.calories_ingredients_id_calories_ingredients_seq', 1, false);


--
-- TOC entry 3453 (class 0 OID 0)
-- Dependencies: 222
-- Name: delivery_id_delivery_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.delivery_id_delivery_seq', 1, false);


--
-- TOC entry 3454 (class 0 OID 0)
-- Dependencies: 220
-- Name: history_of_orders_id_history_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.history_of_orders_id_history_seq', 1, false);


--
-- TOC entry 3455 (class 0 OID 0)
-- Dependencies: 236
-- Name: ingredients_id_ingredients_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ingredients_id_ingredients_seq', 1, false);


--
-- TOC entry 3456 (class 0 OID 0)
-- Dependencies: 219
-- Name: order_id_order_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.order_id_order_seq', 1, false);


--
-- TOC entry 3457 (class 0 OID 0)
-- Dependencies: 224
-- Name: payment_id_payment_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.payment_id_payment_seq', 1, false);


--
-- TOC entry 3458 (class 0 OID 0)
-- Dependencies: 226
-- Name: positions_id_positions_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.positions_id_positions_seq', 1, false);


--
-- TOC entry 3459 (class 0 OID 0)
-- Dependencies: 234
-- Name: positions_order_id_positions_order_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.positions_order_id_positions_order_seq', 1, false);


--
-- TOC entry 3460 (class 0 OID 0)
-- Dependencies: 217
-- Name: user__id_user_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.user__id_user_seq', 1, false);


--
-- TOC entry 3249 (class 2606 OID 16487)
-- Name: burger_constructor burger_constructor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.burger_constructor
    ADD CONSTRAINT burger_constructor_pkey PRIMARY KEY (id_burger_constructor);


--
-- TOC entry 3247 (class 2606 OID 16478)
-- Name: burger burger_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.burger
    ADD CONSTRAINT burger_pkey PRIMARY KEY (id_burger);


--
-- TOC entry 3251 (class 2606 OID 16496)
-- Name: calories_burger calories_burger_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.calories_burger
    ADD CONSTRAINT calories_burger_pkey PRIMARY KEY (id_calories_burger);


--
-- TOC entry 3259 (class 2606 OID 16533)
-- Name: calories_constructor calories_constructor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.calories_constructor
    ADD CONSTRAINT calories_constructor_pkey PRIMARY KEY (id_calories_constructor);


--
-- TOC entry 3257 (class 2606 OID 16524)
-- Name: calories_ingredients calories_ingredients_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.calories_ingredients
    ADD CONSTRAINT calories_ingredients_pkey PRIMARY KEY (id_calories_ingredients);


--
-- TOC entry 3241 (class 2606 OID 16453)
-- Name: delivery delivery_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.delivery
    ADD CONSTRAINT delivery_pkey PRIMARY KEY (id_delivery);


--
-- TOC entry 3239 (class 2606 OID 16447)
-- Name: history_of_orders history_of_orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.history_of_orders
    ADD CONSTRAINT history_of_orders_pkey PRIMARY KEY (id_history);


--
-- TOC entry 3255 (class 2606 OID 16514)
-- Name: ingredients ingredients_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ingredients
    ADD CONSTRAINT ingredients_pkey PRIMARY KEY (id_ingredients);


--
-- TOC entry 3235 (class 2606 OID 16440)
-- Name: order order_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."order"
    ADD CONSTRAINT order_pkey PRIMARY KEY (id_order);


--
-- TOC entry 3243 (class 2606 OID 16459)
-- Name: payment payment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (id_payment);


--
-- TOC entry 3253 (class 2606 OID 16505)
-- Name: positions_order positions_order_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.positions_order
    ADD CONSTRAINT positions_order_pkey PRIMARY KEY (id_positions_order);


--
-- TOC entry 3245 (class 2606 OID 16469)
-- Name: positions_of_history positions_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.positions_of_history
    ADD CONSTRAINT positions_pkey PRIMARY KEY (id_positions);


--
-- TOC entry 3237 (class 2606 OID 16428)
-- Name: user_ user__pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_
    ADD CONSTRAINT user__pkey PRIMARY KEY (id_user);


--
-- TOC entry 3268 (class 2606 OID 16536)
-- Name: burger calories_burger_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.burger
    ADD CONSTRAINT calories_burger_fkey FOREIGN KEY (id_calories_burger) REFERENCES public.calories_burger(id_calories_burger) NOT VALID;


--
-- TOC entry 3266 (class 2606 OID 16592)
-- Name: positions_of_history id_burger; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.positions_of_history
    ADD CONSTRAINT id_burger FOREIGN KEY (id_burger) REFERENCES public.burger(id_burger) NOT VALID;


--
-- TOC entry 3271 (class 2606 OID 16602)
-- Name: positions_order id_burger; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.positions_order
    ADD CONSTRAINT id_burger FOREIGN KEY (id_burger) REFERENCES public.burger(id_burger) NOT VALID;


--
-- TOC entry 3267 (class 2606 OID 16597)
-- Name: positions_of_history id_burger_constructor; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.positions_of_history
    ADD CONSTRAINT id_burger_constructor FOREIGN KEY (id_burger_constructor) REFERENCES public.burger_constructor(id_burger_constructor) NOT VALID;


--
-- TOC entry 3272 (class 2606 OID 16607)
-- Name: positions_order id_burger_constructor; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.positions_order
    ADD CONSTRAINT id_burger_constructor FOREIGN KEY (id_burger_constructor) REFERENCES public.burger_constructor(id_burger_constructor) NOT VALID;


--
-- TOC entry 3269 (class 2606 OID 16554)
-- Name: burger_constructor id_calories_constructor; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.burger_constructor
    ADD CONSTRAINT id_calories_constructor FOREIGN KEY (id_calories_constructor) REFERENCES public.calories_constructor(id_calories_constructor) NOT VALID;


--
-- TOC entry 3273 (class 2606 OID 16570)
-- Name: ingredients id_calories_ingredients; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ingredients
    ADD CONSTRAINT id_calories_ingredients FOREIGN KEY (id_calories_ingredients) REFERENCES public.calories_ingredients(id_calories_ingredients) NOT VALID;


--
-- TOC entry 3260 (class 2606 OID 16575)
-- Name: order id_delivery; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."order"
    ADD CONSTRAINT id_delivery FOREIGN KEY (id_delivery) REFERENCES public.delivery(id_delivery) NOT VALID;


--
-- TOC entry 3264 (class 2606 OID 16612)
-- Name: user_ id_history_of_orders; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_
    ADD CONSTRAINT id_history_of_orders FOREIGN KEY (id_history_of_orders) REFERENCES public.history_of_orders(id_history) NOT VALID;


--
-- TOC entry 3270 (class 2606 OID 16549)
-- Name: burger_constructor id_ingredients; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.burger_constructor
    ADD CONSTRAINT id_ingredients FOREIGN KEY (id_ingredients) REFERENCES public.ingredients(id_ingredients) NOT VALID;


--
-- TOC entry 3261 (class 2606 OID 16580)
-- Name: order id_payment; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."order"
    ADD CONSTRAINT id_payment FOREIGN KEY (id_payment) REFERENCES public.payment(id_payment) NOT VALID;


--
-- TOC entry 3265 (class 2606 OID 16563)
-- Name: history_of_orders id_positions_of_history; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.history_of_orders
    ADD CONSTRAINT id_positions_of_history FOREIGN KEY (id_positions_of_history) REFERENCES public.positions_of_history(id_positions) NOT VALID;


--
-- TOC entry 3262 (class 2606 OID 16585)
-- Name: order id_positions_order; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."order"
    ADD CONSTRAINT id_positions_order FOREIGN KEY (id_positions_order) REFERENCES public.positions_order(id_positions_order) NOT VALID;


--
-- TOC entry 3263 (class 2606 OID 16441)
-- Name: order id_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."order"
    ADD CONSTRAINT id_user FOREIGN KEY (id_user) REFERENCES public.user_(id_user) NOT VALID;


-- Completed on 2023-05-22 14:49:23

--
-- PostgreSQL database dump complete
--

