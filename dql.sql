	select 
		newsTranslation.title as "Title",
		newsTranslation.detail as "Detail",
		newsTranslation.imageurls as "ImageUrls",
		nCategoryTranslation.title as "Category"
		from newstranslation newsTranslation
	inner join news news  on newsTranslation.news_id = news.news_id and news.isdeleted = false
	inner join newscategory nCategory ON newsTranslation.newscategory_id = nCategory.newscategory_id and ncategory = false 
	inner join newscategorytranslation nCategoryTranslation on nCategoryTranslation.newscategory_id = nCategory.newscategory_id 
	and nCategoryTranslation.languagecountrycode = newsTranslation.languagecountrycode  
	and ncategorytranslation.isdeleted = false 
	
	where nCategoryTranslation.languagecountrycode = 'tr'