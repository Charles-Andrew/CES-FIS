PGDMP                  
        z         	   CESFIS_DB    14.5    14.4                 0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                        1262    16549 	   CESFIS_DB    DATABASE     o   CREATE DATABASE "CESFIS_DB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE "CESFIS_DB";
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                postgres    false            !           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   postgres    false    3            ?            1259    16550    balance    TABLE     v   CREATE TABLE public.balance (
    id bigint NOT NULL,
    student_id bigint NOT NULL,
    balance double precision
);
    DROP TABLE public.balance;
       public         heap    postgres    false    3            ?            1259    16553    balance_id_seq    SEQUENCE     ?   ALTER TABLE public.balance ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.balance_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    209    3            ?            1259    16554    expenses    TABLE     ?   CREATE TABLE public.expenses (
    id bigint NOT NULL,
    description character varying(1000) NOT NULL,
    amount double precision NOT NULL,
    date date NOT NULL
);
    DROP TABLE public.expenses;
       public         heap    postgres    false    3            ?            1259    16559    expenses_id_seq    SEQUENCE     ?   ALTER TABLE public.expenses ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.expenses_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);
            public          postgres    false    211    3            ?            1259    16560    funds_transactions    TABLE     ?   CREATE TABLE public.funds_transactions (
    id bigint NOT NULL,
    item_id bigint NOT NULL,
    added_amount double precision NOT NULL,
    transaction_date date NOT NULL
);
 &   DROP TABLE public.funds_transactions;
       public         heap    postgres    false    3            ?            1259    16563    funds_transactions_id_seq    SEQUENCE     ?   ALTER TABLE public.funds_transactions ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.funds_transactions_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);
            public          postgres    false    3    213            ?            1259    16564    items    TABLE     `   CREATE TABLE public.items (
    id bigint NOT NULL,
    name character varying(500) NOT NULL
);
    DROP TABLE public.items;
       public         heap    postgres    false    3            ?            1259    16569    items_id_seq    SEQUENCE     ?   ALTER TABLE public.items ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.items_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    3    215            ?            1259    16644    logs    TABLE     i   CREATE TABLE public.logs (
    id bigint NOT NULL,
    details character varying(1000),
    date date
);
    DROP TABLE public.logs;
       public         heap    postgres    false    3            ?            1259    16643    logs_id_seq    SEQUENCE     ?   ALTER TABLE public.logs ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.logs_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    224    3            ?            1259    16570    payments    TABLE     ?   CREATE TABLE public.payments (
    id bigint NOT NULL,
    payor_id bigint NOT NULL,
    date date NOT NULL,
    amount double precision NOT NULL
);
    DROP TABLE public.payments;
       public         heap    postgres    false    3            ?            1259    16573    payments_id_seq    SEQUENCE     ?   ALTER TABLE public.payments ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.payments_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);
            public          postgres    false    217    3            ?            1259    16574    students    TABLE     H  CREATE TABLE public.students (
    id bigint NOT NULL,
    family_name character varying(255) NOT NULL,
    given_name character varying(255) NOT NULL,
    middle_name character varying(255) NOT NULL,
    course character varying(500) NOT NULL,
    "EdAt_Elem" character varying(500),
    "EdAt_HS" character varying(500),
    "EdAt_Vocational" character varying(500),
    "EdAt_College" character varying(500),
    occupation character varying(500),
    present_job character varying(500),
    occupation_address character varying(500),
    employer character varying(500),
    spouse_occupation character varying(500),
    contact_number character varying(11),
    home_address character varying(500) NOT NULL,
    "DOB" date NOT NULL,
    age integer NOT NULL,
    civil_status character varying NOT NULL,
    "AYE" character varying
);
    DROP TABLE public.students;
       public         heap    postgres    false    3            ?            1259    16579    students_id_seq    SEQUENCE     ?   ALTER TABLE public.students ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.students_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219    3            ?            1259    16580    users    TABLE     ?   CREATE TABLE public.users (
    id bigint NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL,
    is_admin boolean NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false    3            ?            1259    16585    users_id_seq    SEQUENCE     ?   ALTER TABLE public.users ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.users_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    3    221            ?           2606    16587    balance balance_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.balance
    ADD CONSTRAINT balance_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.balance DROP CONSTRAINT balance_pkey;
       public            postgres    false    209            ?           2606    16589    expenses expenses_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.expenses
    ADD CONSTRAINT expenses_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.expenses DROP CONSTRAINT expenses_pkey;
       public            postgres    false    211            ?           2606    16591 *   funds_transactions funds_transactions_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.funds_transactions
    ADD CONSTRAINT funds_transactions_pkey PRIMARY KEY (id);
 T   ALTER TABLE ONLY public.funds_transactions DROP CONSTRAINT funds_transactions_pkey;
       public            postgres    false    213            ?           2606    16593    items items_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.items
    ADD CONSTRAINT items_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.items DROP CONSTRAINT items_pkey;
       public            postgres    false    215            ?           2606    16650    logs logs_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.logs
    ADD CONSTRAINT logs_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.logs DROP CONSTRAINT logs_pkey;
       public            postgres    false    224            ?           2606    16595    students students_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.students DROP CONSTRAINT students_pkey;
       public            postgres    false    219            ?           2606    16597    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    221            ?           2606    16598    payments fk_payment_student    FK CONSTRAINT     ?   ALTER TABLE ONLY public.payments
    ADD CONSTRAINT fk_payment_student FOREIGN KEY (payor_id) REFERENCES public.students(id) ON UPDATE CASCADE ON DELETE RESTRICT;
 E   ALTER TABLE ONLY public.payments DROP CONSTRAINT fk_payment_student;
       public          postgres    false    217    3208    219            ?           2606    16603    balance fk_student_balance    FK CONSTRAINT     ?   ALTER TABLE ONLY public.balance
    ADD CONSTRAINT fk_student_balance FOREIGN KEY (student_id) REFERENCES public.students(id) ON UPDATE CASCADE ON DELETE RESTRICT;
 D   ALTER TABLE ONLY public.balance DROP CONSTRAINT fk_student_balance;
       public          postgres    false    3208    209    219            ?           2606    16608 &   funds_transactions pk_item_transaction    FK CONSTRAINT     ?   ALTER TABLE ONLY public.funds_transactions
    ADD CONSTRAINT pk_item_transaction FOREIGN KEY (item_id) REFERENCES public.items(id) ON UPDATE CASCADE ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public.funds_transactions DROP CONSTRAINT pk_item_transaction;
       public          postgres    false    215    3206    213           