INSERT INTO newscategory
(newscategory_id, isactive, isdeleted)
VALUES(1, true, false);
INSERT INTO newscategory
(newscategory_id, isactive, isdeleted)
VALUES(2, true, false);

INSERT INTO newscategorytranslation
(newscategorytranslation_id, newscategory_id, isactive, isdeleted, title, languagecountrycode)
VALUES(1, 1, true, false, 'Economy Category', 'en');
INSERT INTO newscategorytranslation
(newscategorytranslation_id, newscategory_id, isactive, isdeleted, title, languagecountrycode)
VALUES(2, 1, true, false, 'Ekonomi Kategorisi', 'tr');
INSERT INTO newscategorytranslation
(newscategorytranslation_id, newscategory_id, isactive, isdeleted, title, languagecountrycode)
VALUES(3, 2, true, false, 'Eğitim Kategorisi', 'tr');
INSERT INTO newscategorytranslation
(newscategorytranslation_id, newscategory_id, isactive, isdeleted, title, languagecountrycode)
VALUES(4, 2, true, false, 'Education Category', 'en');

INSERT INTO news
(news_id, isactive, isdeleted)
VALUES(1, true, false);
INSERT INTO news
(news_id, isactive, isdeleted)
VALUES(2, true, false);

INSERT INTO newstranslation
(newstranslation_id, news_id, newscategory_id, isactive, isdeleted, title, detail, imageurls, languagecountrycode)
VALUES(1, 1, 1, true, false, 'tr-News1-Başlık', 'tr-News1-Detay', 'tr-News1-ImgUrl1, tr-News1-ImgUrl2,…, tr-News1-ImgUrln', 'tr');
INSERT INTO newstranslation
(newstranslation_id, news_id, newscategory_id, isactive, isdeleted, title, detail, imageurls, languagecountrycode)
VALUES(2, 1, 1, true, false, 'en-News1-Title', 'en-News1-Detail', 'en-News1-ImgUrl1, en-News1-ImgUrl2,…, en-News1-ImgUrln', 'en');
INSERT INTO newstranslation
(newstranslation_id, news_id, newscategory_id, isactive, isdeleted, title, detail, imageurls, languagecountrycode)
VALUES(3, 2, 2, true, false, 'en-News2-Title', 'en-News2-Detail', 'en-News2-ImgUrl1, en-News2-ImgUrl2,…, en-News2-ImgUrln', 'en');
INSERT INTO newstranslation
(newstranslation_id, news_id, newscategory_id, isactive, isdeleted, title, detail, imageurls, languagecountrycode)
VALUES(4, 2, 2, true, false, 'tr-News2-Başlık', 'tr-News2-Detay', 'tr-News2-ImgUrl1, tr-News2-ImgUrl2,…, tr-News2-ImgUrln', 'tr');