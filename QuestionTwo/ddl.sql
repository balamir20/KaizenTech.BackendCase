CREATE TABLE NewsCategory (
	id INT PRIMARY key not NULL,
    isActive BOOLEAN NOT null,
    isDeleted BOOLEAN NOT null  
);

CREATE TABLE NewsCategoryTranslation (
	newsCategoryTranslation_Id INT PRIMARY key not NULL,
	id INT,
    isActive BOOLEAN NOT null,
    isDeleted BOOLEAN NOT null,
    title VARCHAR (255) NOT NULL,
    languageCountryCode VARCHAR (8) NOT NULL,
	CONSTRAINT fk_newsCategory
      FOREIGN KEY(id) 
	  REFERENCES NewsCategory(id)
);

CREATE TABLE News (
	news_id int PRIMARY KEY NOT NULL,
    isActive BOOLEAN NOT null,
    isDeleted BOOLEAN NOT NULL 
);

CREATE TABLE NewsTranslation (
	newsTranslation_Id INT PRIMARY key not NULL,
	news_id INT,
	newscategory_id INT,
    isActive BOOLEAN NOT null,
    isDeleted BOOLEAN NOT null,
    title VARCHAR (255) NOT NULL,
    detail VARCHAR (255) NOT NULL,
    imageUrls VARCHAR (512),
    languageCountryCode VARCHAR (8) NOT NULL,
      FOREIGN KEY(news_id) 	  REFERENCES News(news_id),
	
	 FOREIGN KEY(newscategory_id)      REFERENCES newscategory(newscategory_id)
);