#!/bin/bash

if [! -f ./results/tests_done ]; then
	docker compose down -v
fi
