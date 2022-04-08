			-- Step : 01.2
			/*********************************************************************************************************************************************************
			-- Gool : Fill table [dbo].[Communication] with data
			-- ********************************************************************************************************************************************************
			-- Version    Date           Author      Description
			-- ******     **********     *******     **************
			-- 01         21-12-2021     JamilM       New 
			-- *********************************************************************************************************************************************************/ 
			-- Check whether the table exists
			IF (EXISTS (
							SELECT    * 
							FROM      INFORMATION_SCHEMA.TABLES 
							WHERE     TABLE_SCHEMA  = 'dbo' 
							  AND     TABLE_NAME    = 'Communication'
						)
				)
			BEGIN
				USE [Warehouse]
				INSERT INTO [dbo].[Communication] 
				(
					 [Street]			
					,[Number]			
					,[NumberExtension]	
					,[ZipCode]			
					,[Place]			
					,[Province]			
					,[Phone]			
					,[Mobile]			
					,[Fax]				
					,[Email]			
					,[Website]			
					,[Addresstype]		
					,[Communicationkey]     
					,[IsActive]     
					,[Description]  
					,[DateCreated]  
					,[DateModified]    
				)
				VALUES 
				 ('Niegerdreef', '523', NULL, '1111 PP', 'Utrecht', 'Utrecht', NULL, '0612345670', NULL, 'test01@email.nl', NULL, 'Post', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Hollandlaan', '15', NULL, '2222 TY', 'Amsterdam', 'Noord-Holland', NULL, '0612345671', NULL, 'test02@email.nl', NULL, 'Visit', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Duivenkamp', '17', NULL, '3607 PE', 'Maarssen', 'Utrecht', NULL, '0612345672', NULL, 'test03@email.nl', NULL, 'Post', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Straatnaam01', '300', NULL, '3607 PE', 'Soest', 'Utrecht', NULL, '0612345673', NULL, 'test04@email.nl', NULL, 'Post', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Straatnaam02', '299', NULL, '3606 PA', 'Alkmaar', 'Noord-Holland', NULL, '0612345674', NULL, 'test05@email.nl', NULL, 'Post', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Straatnaam03', '298', NULL, '3605 PH', 'Haarlem', 'Noord-Holland', NULL, '0612345675', NULL, 'test06@email.nl', NULL, 'Visit', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Straatnaam04', '297', NULL, '3604 PC', 'Volendam', 'Noord-Holland', NULL, '0612345676', NULL, 'test07@email.nl', NULL, 'Post', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Straatnaam05', '296', NULL, '3603 PV', 'Zwolle', 'Overijssel', NULL, '0612345677', NULL, 'test08@email.nl', NULL, 'Post', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Straatnaam06', '295', NULL, '3602 PW', 'Almere', 'Flevoland', NULL, '0612345678', NULL, 'test09@email.nl', NULL, 'Post', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
				,('Straatnaam07', '294', NULL, '3601 PQ', 'Groningen', 'Groningen', NULL, '0612345679', NULL, 'test10@email.nl', NULL, 'Visit', NEWID(), 1, NULL, SYSDATETIME(), SYSDATETIME())
			END