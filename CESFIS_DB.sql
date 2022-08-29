PGDMP     9                     z         	   CESFIS_DB    14.4    14.4                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16394 	   CESFIS_DB    DATABASE     o   CREATE DATABASE "CESFIS_DB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE "CESFIS_DB";
                postgres    false            �            1259    16467    balance    TABLE     v   CREATE TABLE public.balance (
    id bigint NOT NULL,
    student_id bigint NOT NULL,
    balance double precision
);
    DROP TABLE public.balance;
       public         heap    postgres    false            �            1259    16466    balance_id_seq    SEQUENCE     �   ALTER TABLE public.balance ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.balance_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    220            �            1259    16478    expenses    TABLE     �   CREATE TABLE public.expenses (
    id bigint NOT NULL,
    description character varying(1000) NOT NULL,
    amount double precision NOT NULL,
    date date NOT NULL
);
    DROP TABLE public.expenses;
       public         heap    postgres    false            �            1259    16477    expenses_id_seq    SEQUENCE     �   ALTER TABLE public.expenses ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.expenses_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);
            public          postgres    false    222            �            1259    16456    funds_transactions    TABLE     �   CREATE TABLE public.funds_transactions (
    id bigint NOT NULL,
    item_id bigint NOT NULL,
    added_amount double precision NOT NULL,
    transaction_date date NOT NULL
);
 &   DROP TABLE public.funds_transactions;
       public         heap    postgres    false            �            1259    16455    funds_transactions_id_seq    SEQUENCE     �   ALTER TABLE public.funds_transactions ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.funds_transactions_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);
            public          postgres    false    218            �            1259    16447    items    TABLE     `   CREATE TABLE public.items (
    id bigint NOT NULL,
    name character varying(500) NOT NULL
);
    DROP TABLE public.items;
       public         heap    postgres    false            �            1259    16446    items_id_seq    SEQUENCE     �   ALTER TABLE public.items ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.items_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    216            �            1259    16438    payments    TABLE     �   CREATE TABLE public.payments (
    id bigint NOT NULL,
    payor_id bigint NOT NULL,
    date date NOT NULL,
    amount double precision NOT NULL
);
    DROP TABLE public.payments;
       public         heap    postgres    false            �            1259    16437    payments_id_seq    SEQUENCE     �   ALTER TABLE public.payments ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.payments_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
    CYCLE
);
            public          postgres    false    214            �            1259    16430    students    TABLE     +  CREATE TABLE public.students (
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
    civil_status character varying NOT NULL
);
    DROP TABLE public.students;
       public         heap    postgres    false            �            1259    16429    students_id_seq    SEQUENCE     �   ALTER TABLE public.students ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.students_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    212            �            1259    16403    users    TABLE     �   CREATE TABLE public.users (
    id bigint NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL,
    is_admin boolean NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false            �            1259    16428    users_id_seq    SEQUENCE     �   ALTER TABLE public.users ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.users_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    209            �           2606    16471    balance balance_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.balance
    ADD CONSTRAINT balance_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.balance DROP CONSTRAINT balance_pkey;
       public            postgres    false    220            �           2606    16484    expenses expenses_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.expenses
    ADD CONSTRAINT expenses_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.expenses DROP CONSTRAINT expenses_pkey;
       public            postgres    false    222            �           2606    16460 *   funds_transactions funds_transactions_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.funds_transactions
    ADD CONSTRAINT funds_transactions_pkey PRIMARY KEY (id);
 T   ALTER TABLE ONLY public.funds_transactions DROP CONSTRAINT funds_transactions_pkey;
       public            postgres    false    218                       2606    16454    items items_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.items
    ADD CONSTRAINT items_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.items DROP CONSTRAINT items_pkey;
       public            postgres    false    216            }           2606    16436    students students_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.students DROP CONSTRAINT students_pkey;
       public            postgres    false    212            {           2606    16407    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    209            �           2606    16441    payments fk_payment_student    FK CONSTRAINT     �   ALTER TABLE ONLY public.payments
    ADD CONSTRAINT fk_payment_student FOREIGN KEY (payor_id) REFERENCES public.students(id) ON UPDATE CASCADE ON DELETE RESTRICT;
 E   ALTER TABLE ONLY public.payments DROP CONSTRAINT fk_payment_student;
       public          postgres    false    212    3197    214            �           2606    16472    balance fk_student_balance    FK CONSTRAINT     �   ALTER TABLE ONLY public.balance
    ADD CONSTRAINT fk_student_balance FOREIGN KEY (student_id) REFERENCES public.students(id) ON UPDATE CASCADE ON DELETE RESTRICT;
 D   ALTER TABLE ONLY public.balance DROP CONSTRAINT fk_student_balance;
       public          postgres    false    3197    212    220            �           2606    16461 &   funds_transactions pk_item_transaction    FK CONSTRAINT     �   ALTER TABLE ONLY public.funds_transactions
    ADD CONSTRAINT pk_item_transaction FOREIGN KEY (item_id) REFERENCES public.items(id) ON UPDATE CASCADE ON DELETE RESTRICT;
 P   ALTER TABLE ONLY public.funds_transactions DROP CONSTRAINT pk_item_transaction;
       public          postgres    false    3199    218    216           