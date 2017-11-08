/*
 * csv_practice.cxx
 * 
 * Copyright 2017 Brandon Williams <brandon.w2055@gmail.com>
 * 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301, USA.
 * 
 * 
 */

/* This program is a unit test of a csv file identifier. We examine if the file
 * exists, then we examine if the file is a csv file.
 */


#include <iostream>
#include <fstream>
#include <sys/stat.h>

using namespace std;

bool fileExists(const string& filename)
{
    struct stat buf;
    if (stat(filename.c_str(), &buf) != -1)
    {
        return true;
    }
    return false;
}

bool csv_exist(string file_name){
	bool file_type_csv;
	
	if (fileExists(file_name)==true){
		cout<<file_name<<" exists."<<endl;
	}
	else{
		cout<<"File "<<file_name<<" doesn't exist."<<endl;
	}
	if(file_name.substr(file_name.find_last_of(".") + 1) == "csv") {
		file_type_csv=true;
	} else {
		//cout <<file_name<<" isn't a csv file"<<endl;
		file_type_csv=false;
	}
	return file_type_csv;
}

void csv_exist_test(string f_name){
	if (csv_exist(f_name)==true){
		cout<<f_name<<" works"<<endl;
	}
	else{
		cout<<f_name<<" doesn't work"<<endl;
	}
}

int main(int argc, char **argv)
{
	/* 
	 * Try three seperate cases with the csv_exist function:
	 * 1.) a real file & csv
	 * 2.) a real file & not csv
	 * 3.) not a real file
	*/
	csv_exist_test("csvtry_1.csv");
	csv_exist_test("text_notcsv.txt");
	csv_exist_test("is_this_an_existing_file.file");
	
	
	return 0;
}

