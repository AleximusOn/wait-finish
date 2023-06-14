#!/bin/bash

script_root="${0%/*}"
cd $script_root

if [ -f ./results/TEST_IS_DONE.txt ]; then
	# remove TEST_IS_DONE
	rm ./results/TEST_IS_DONE.txt
	
	# down compose with remove volumes
	docker compose down -v
	
	# remove this script from cron
	crontab -l | grep -v "$0" | crontab -
fi
