--create database
CREATE DATABASE Railway_Express;

-- Tables--

	CREATE TABLE ACCOUNT
	(
		Num						INT		IDENTITY (1,1)  NOT NULL, 

		 
		account_id AS 'R' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,

		Roll_Type               VARCHAR (20)			NOT NULL,
		Login_Username			VARCHAR (20)			NOT NULL, 
		Login_Password			VARCHAR (20)			NOT NULL,
		E_mail					VARCHAR (20)			NOT NULL,
		first_name				VARCHAR(50)				NOT NULL,
		last_name				VARCHAR(50)				NOT NULL,
		NIC						VARCHAR(12)				NOT NULL,
		mobile_no				INT						NOT NULL,

		CONSTRAINT pk_EMPLOYEE PRIMARY KEY (account_id),
		--ON DELETE CASCADE,

	);

	SELECT * FROM ACCOUNT;
	INSERT INTO ACCOUNT VALUES('ADMIN','sachintha','madhawa','sa@gmail.com','sachintha','madhawa','432834983','0701871192');
	INSERT INTO ACCOUNT VALUES('EMPLOYEE','lahiru','suwahas','sa@gmail.com','lahiru','suwahas','432834983','0701871192');
	INSERT INTO ACCOUNT VALUES('USER','sarasa','udana','sa@gmail.com','sarasa','udana','432834983','0701871192');
	

	CREATE TABLE EMPLOYEE
	(	Employee_Id				VARCHAR(9)				NOT NULL,
		employee_address		VARCHAR(50)				NOT  NULL,	
		join_date				DATE					NOT NULL,
		basic_salary			DECIMAL					NOT NULL,

		CONSTRAINT pk_EMPLOYEE PRIMARY KEY (Employee_Id),
		CONSTRAINT fk_ FOREIGN KEY (Employee_Id) REFERENCES ACCOUNT(account_id)
	);





	CREATE TABLE USERr
	(	
		user__id				VARCHAR(9)				NOT NULL,
		user_address			VARCHAR(50)				NOT NULL,	
		basic_salary			INT						NOT NULL,
		A_Create_Date			DATE					NOT NULL,
		A_Create_Time			TIME					NOT NULL,

		CONSTRAINT pk_USERr PRIMARY KEY (user__Id),
		CONSTRAINT fk_ FOREIGN KEY (user__id) REFERENCES ACCOUNT(account_id)
	);


	CREATE TABLE RESOURT
	(
		Num						INT		IDENTITY (1,1)  NOT NULL,
		resourt_Id AS 'R' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,

		resourt_name			VARCHAR(40)				NOT NULL,
		room_type				VARCHAR(60)				NOT NULL,
		room_price				DECIMAL					NOT NULL,
		room_availability		VARCHAR(50)				NOT NULL,

		CONSTRAINT pk_RESOURT PRIMARY KEY (RESOURT_Id)

	);

	CREATE TABLE CANTEEN
	(
		Num						INT		IDENTITY (1,1)  NOT NULL,
		iteam_Id AS 'I' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,

		iteam_name				VARCHAR(20)				NOT NULL,
		iteam_price				INT						NOT NULL,
		avalable_count			INT						NOT NULL,

		CONSTRAINT pk_CANTEEN PRIMARY KEY (iteam_Id)

	);

	CREATE TABLE RAIL_WAY_LINE
	(
	 Num						INT		IDENTITY (1,1)  NOT NULL,
	 rail_way_line_id AS 'L' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,

	 station_name				VARCHAR(20)				NOT NULL,
	 main_station				VARCHAR(20)				NOT NULL,
	 end_station				VARCHAR(20)				NOT NULL,
	 rate_per_km				INT						NOT NULL,

	 CONSTRAINT pk_rail_way_line_id PRIMARY KEY (rail_way_line_id)
	);

	select *from RAIL_WAY_LINE;


	CREATE TABLE STATION
	(
		Num						INT		IDENTITY (1,1)  NOT NULL,
		station_id AS 'S' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,
		
		station_name					VARCHAR(20)					NOT NULL,
		rail_way_line_id				VARCHAR(8)					NOT NULL,
		far_from_main_station   INT							NOT NULL,

		CONSTRAINT pk_station PRIMARY KEY (station_id),
		CONSTRAINT fk_station FOREiGN KEY (rail_way_line_id)REFERENCES RAIL_WAY_LINE

	);

	select *from STATION;


		insert into STATION values('matara','L0001',6);

	CREATE TABLE PARSALE
	(
		Num						INT		IDENTITY (1,1)  NOT NULL,
		parscel_id AS 'p' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,

		ptype				VARCHAR(10)		NOT NULL,
		send_date			DATE			NOT NULL,
		

		CONSTRAINT pk_parscel_id PRIMARY KEY (parscel_id)
	);

	CREATE TABLE USER_RESOURT
	(
			user__id				VARCHAR(9)				NOT NULL,
			resourt_Id				VARCHAR(9)				NOT NULL,

			CONSTRAINT pk_USER_RESOURT PRIMARY KEY (user__id,resourt_Id),
			CONSTRAINT fk_USER_RESOURT FOREIGN KEY(user__id) REFERENCES(USERr),
			CONSTRAINT fk_USER_RESOURT FOREIGN KEY(resourt_Id) REFERENCES(RESOURT)
	);



	CREATE TABLE Train_Ticket
	(
		Num						INT		IDENTITY (1,1)  NOT NULL,
		Train_Ticket_id AS 'TT' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,


		ticket_class_type				 VARCHAR(20)			NOT NULL,
		ticket_class_rate				 INT				   	NOT NULL,

		CONSTRAINT pk_train_ticket  PRIMARY KEY(Train_Ticket_id),
		
	)

	INSERT INTO Train_Ticket VALUES('First class',15);

	CREATE TABLE TRAIN 
	(
		Num						INT		IDENTITY (1,1)  NOT NULL, 

		 
		train_id AS 'T' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,

		train_name				VARCHAR(20)					NOT NULL,
		train_type				VARCHAR(20)					NOT NULL,
		train_Engine_number		VARCHAR(20)					NOT NULL,
		Train_carriages			INT							NOT NULL,


		CONSTRAINT pk_TRAIN	PRIMARY KEY(train_id)

	)